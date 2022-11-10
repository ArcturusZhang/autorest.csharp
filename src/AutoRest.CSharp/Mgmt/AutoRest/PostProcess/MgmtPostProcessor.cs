﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoRest.CSharp.AutoRest.Plugins;
using AutoRest.CSharp.Common.Output.PostProcessing;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Models.Types;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AutoRest.CSharp.Mgmt.AutoRest.PostProcess
{
    internal class MgmtPostProcessor : PostProcessor
    {
        private readonly ImmutableHashSet<string> _modelsToKeep;
        public MgmtPostProcessor(Project project, ImmutableHashSet<string> modelsToKeep) : base(project)
        {
            _modelsToKeep = modelsToKeep;
        }

        protected override async Task<HashSet<BaseTypeDeclarationSyntax>> GetRootNodes(bool publicOnly)
        {
            var classVisitor = new DefinitionVisitor(publicOnly);
            foreach (var document in project.Documents)
            {
                var root = await document.GetSyntaxRootAsync();
                // we add a declaration as root node when
                // 1. the file is under `Generated` or `Generated/Extensions` which is handled by `IsMgmtRootDocument`
                // 2. the declaration has a ReferenceType or similar attribute on it which is handled by `IsReferenceType`
                // 3. the file is custom code (not generated and not shared) which is handled by `IsCustomDocument`
                if (IsMgmtRootDocument(document) || IsReferenceType(root) || GeneratedCodeWorkspace.IsCustomDocument(document) || ShouldKeepModel(root, _modelsToKeep))
                {
                    classVisitor.Visit(root);
                }
            }

            return classVisitor.ModelDeclarations;
        }

        private static bool IsMgmtRootDocument(Document document) => GeneratedCodeWorkspace.IsGeneratedDocument(document) && Path.GetDirectoryName(document.Name) is "Extensions" or "";

        private static HashSet<string> _referenceAttributes = new HashSet<string> { "ReferenceType", "PropertyReferenceType", "TypeReferenceType" };

        private static bool IsReferenceType(SyntaxNode? root)
        {
            if (root is null)
                return false;

            var childNodes = root.DescendantNodes();
            var typeNode = childNodes.OfType<TypeDeclarationSyntax>().FirstOrDefault();
            if (typeNode is null)
            {
                return false;
            }

            var attributeLists = GetAttributeLists(typeNode);
            if (attributeLists is null || attributeLists.Value.Count == 0)
                return false;

            foreach (var attributeList in attributeLists.Value)
            {
                if (_referenceAttributes.Contains(attributeList.Attributes[0].Name.ToString()))
                    return true;
            }

            return false;
        }

        private static bool ShouldKeepModel(SyntaxNode? root, ImmutableHashSet<string> modelsToKeep)
        {
            if (root is null)
                return false;

            // use `BaseTypeDeclarationSyntax` to also include enums because `EnumDeclarationSyntax` extends `BaseTypeDeclarationSyntax`
            // `ClassDeclarationSyntax` and `StructDeclarationSyntax` both inherit `TypeDeclarationSyntax`
            var typeNodes = root.DescendantNodes().OfType<BaseTypeDeclarationSyntax>();
            // there is possibility that we have multiple types defined in the same document (for instance, custom code)
            return typeNodes.Any(t => modelsToKeep.Contains(t.Identifier.Text));
        }

        private static SyntaxList<AttributeListSyntax>? GetAttributeLists(SyntaxNode node)
        {
            if (node is StructDeclarationSyntax structDeclaration)
                return structDeclaration.AttributeLists;

            if (node is ClassDeclarationSyntax classDeclaration)
                return classDeclaration.AttributeLists;

            return null;
        }
    }
}
