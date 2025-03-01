﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using AutoRest.CSharp.Common.Output.Expressions.ValueExpressions;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;

namespace AutoRest.CSharp.Output.Models.Serialization.Xml
{
    internal abstract class XmlPropertySerialization : PropertySerialization
    {
        public string PropertyName { get; }

        protected XmlPropertySerialization(string serializedName, CSharpType serializedType, ObjectTypeProperty property)
            : base(property.Declaration.Name.ToVariableName(), new TypedMemberExpression(null, property.Declaration.Name, property.Declaration.Type), serializedName, serializedType, property.SchemaProperty?.Required ?? property.InputModelProperty?.IsRequired ?? false, property.SchemaProperty?.ReadOnly ?? property.InputModelProperty?.IsReadOnly ?? false, property)
        {
            PropertyName = property.Declaration.Name;
        }
    }
}
