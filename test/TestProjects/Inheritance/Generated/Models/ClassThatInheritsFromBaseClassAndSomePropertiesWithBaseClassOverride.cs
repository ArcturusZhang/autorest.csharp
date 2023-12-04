// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Inheritance.Models
{
    /// <summary> The ClassThatInheritsFromBaseClassAndSomePropertiesWithBaseClassOverride. </summary>
    internal partial class ClassThatInheritsFromBaseClassAndSomePropertiesWithBaseClassOverride : SomeProperties
    {
        /// <summary> Initializes a new instance of <see cref="ClassThatInheritsFromBaseClassAndSomePropertiesWithBaseClassOverride"/>. </summary>
        public ClassThatInheritsFromBaseClassAndSomePropertiesWithBaseClassOverride()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClassThatInheritsFromBaseClassAndSomePropertiesWithBaseClassOverride"/>. </summary>
        /// <param name="someProperty"></param>
        /// <param name="someOtherProperty"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="baseClassProperty"></param>
        /// <param name="dfeString"> Any object. </param>
        /// <param name="dfeDouble"> Any object. </param>
        /// <param name="dfeBool"> Any object. </param>
        /// <param name="dfeInt"> Any object. </param>
        /// <param name="dfeObject"> Any object. </param>
        /// <param name="dfeListOfT"> Any object. </param>
        /// <param name="dfeListOfString"> Any object. </param>
        /// <param name="dfeKeyValuePairs"> Any object. </param>
        /// <param name="dfeDateTime"> Any object. </param>
        /// <param name="dfeDuration"> Any object. </param>
        /// <param name="dfeUri"> Any object. </param>
        internal ClassThatInheritsFromBaseClassAndSomePropertiesWithBaseClassOverride(string someProperty, string someOtherProperty, IDictionary<string, BinaryData> serializedAdditionalRawData, string baseClassProperty, DataFactoryElement<string> dfeString, DataFactoryElement<double> dfeDouble, DataFactoryElement<bool> dfeBool, DataFactoryElement<int> dfeInt, DataFactoryElement<BinaryData> dfeObject, DataFactoryElement<IList<SeparateClass>> dfeListOfT, DataFactoryElement<IList<string>> dfeListOfString, DataFactoryElement<IDictionary<string, string>> dfeKeyValuePairs, DataFactoryElement<DateTimeOffset> dfeDateTime, DataFactoryElement<TimeSpan> dfeDuration, DataFactoryElement<Uri> dfeUri) : base(someProperty, someOtherProperty, serializedAdditionalRawData)
        {
            BaseClassProperty = baseClassProperty;
            DfeString = dfeString;
            DfeDouble = dfeDouble;
            DfeBool = dfeBool;
            DfeInt = dfeInt;
            DfeObject = dfeObject;
            DfeListOfT = dfeListOfT;
            DfeListOfString = dfeListOfString;
            DfeKeyValuePairs = dfeKeyValuePairs;
            DfeDateTime = dfeDateTime;
            DfeDuration = dfeDuration;
            DfeUri = dfeUri;
        }

        /// <summary> Gets or sets the base class property. </summary>
        public string BaseClassProperty { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<string> DfeString { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<double> DfeDouble { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<bool> DfeBool { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<int> DfeInt { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<BinaryData> DfeObject { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<IList<SeparateClass>> DfeListOfT { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<IList<string>> DfeListOfString { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<IDictionary<string, string>> DfeKeyValuePairs { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<DateTimeOffset> DfeDateTime { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<TimeSpan> DfeDuration { get; set; }
        /// <summary> Any object. </summary>
        public DataFactoryElement<Uri> DfeUri { get; set; }
    }
}
