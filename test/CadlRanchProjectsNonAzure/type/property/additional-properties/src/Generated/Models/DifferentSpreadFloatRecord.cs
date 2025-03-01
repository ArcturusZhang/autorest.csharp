// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    /// <summary> The model spread Record&lt;float32&gt; with the different known property type. </summary>
    public partial class DifferentSpreadFloatRecord
    {
        /// <summary> Initializes a new instance of <see cref="DifferentSpreadFloatRecord"/>. </summary>
        /// <param name="name"> The id property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DifferentSpreadFloatRecord(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            AdditionalProperties = new ChangeTrackingDictionary<string, float>();
        }

        /// <summary> Initializes a new instance of <see cref="DifferentSpreadFloatRecord"/>. </summary>
        /// <param name="name"> The id property. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DifferentSpreadFloatRecord(string name, IDictionary<string, float> additionalProperties)
        {
            Name = name;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="DifferentSpreadFloatRecord"/> for deserialization. </summary>
        internal DifferentSpreadFloatRecord()
        {
        }

        /// <summary> The id property. </summary>
        public string Name { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, float> AdditionalProperties { get; }
    }
}
