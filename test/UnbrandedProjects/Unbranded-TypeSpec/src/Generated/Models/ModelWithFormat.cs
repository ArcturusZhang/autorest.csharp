// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Internal;

namespace UnbrandedTypeSpec.Models
{
    /// <summary> The ModelWithFormat. </summary>
    public partial class ModelWithFormat
    {
        /// <summary> Initializes a new instance of <see cref="ModelWithFormat"/>. </summary>
        /// <param name="sourceUrl"> url format. </param>
        /// <param name="guid"> uuid format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceUrl"/> is null. </exception>
        public ModelWithFormat(Uri sourceUrl, Guid guid)
        {
            ClientUtilities.AssertNotNull(sourceUrl, nameof(sourceUrl));

            SourceUrl = sourceUrl;
            Guid = guid;
        }

        /// <summary> url format. </summary>
        public Uri SourceUrl { get; }
        /// <summary> uuid format. </summary>
        public Guid Guid { get; }
    }
}
