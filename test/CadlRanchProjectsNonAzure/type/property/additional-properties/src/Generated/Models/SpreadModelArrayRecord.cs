// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    /// <summary> The SpreadModelArrayRecord. </summary>
    public partial class SpreadModelArrayRecord
    {
        /// <summary> Initializes a new instance of <see cref="SpreadModelArrayRecord"/>. </summary>
        /// <param name="knownProp"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="knownProp"/> is null. </exception>
        public SpreadModelArrayRecord(IEnumerable<ModelForRecord> knownProp)
        {
            Argument.AssertNotNull(knownProp, nameof(knownProp));

            KnownProp = knownProp.ToList();
            AdditionalProperties = new ChangeTrackingDictionary<string, IList<ModelForRecord>>();
        }

        /// <summary> Initializes a new instance of <see cref="SpreadModelArrayRecord"/>. </summary>
        /// <param name="knownProp"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SpreadModelArrayRecord(IList<ModelForRecord> knownProp, IDictionary<string, IList<ModelForRecord>> additionalProperties)
        {
            KnownProp = knownProp;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="SpreadModelArrayRecord"/> for deserialization. </summary>
        internal SpreadModelArrayRecord()
        {
        }

        /// <summary> Gets the known prop. </summary>
        public IList<ModelForRecord> KnownProp { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, IList<ModelForRecord>> AdditionalProperties { get; }
    }
}
