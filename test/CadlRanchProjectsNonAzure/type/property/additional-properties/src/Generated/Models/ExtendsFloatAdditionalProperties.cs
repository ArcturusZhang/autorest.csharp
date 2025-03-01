// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    /// <summary> The model extends from Record&lt;float32&gt; type. </summary>
    public partial class ExtendsFloatAdditionalProperties
    {
        /// <summary> Initializes a new instance of <see cref="ExtendsFloatAdditionalProperties"/>. </summary>
        /// <param name="id"> The id property. </param>
        public ExtendsFloatAdditionalProperties(float id)
        {
            Id = id;
            AdditionalProperties = new ChangeTrackingDictionary<string, float>();
        }

        /// <summary> Initializes a new instance of <see cref="ExtendsFloatAdditionalProperties"/>. </summary>
        /// <param name="id"> The id property. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ExtendsFloatAdditionalProperties(float id, IDictionary<string, float> additionalProperties)
        {
            Id = id;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="ExtendsFloatAdditionalProperties"/> for deserialization. </summary>
        internal ExtendsFloatAdditionalProperties()
        {
        }

        /// <summary> The id property. </summary>
        public float Id { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, float> AdditionalProperties { get; }
    }
}
