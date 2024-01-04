// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class ListModelsResponse
    {
        internal static ListModelsResponse DeserializeListModelsResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @object = default;
            IReadOnlyList<Model> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("object"u8))
                {
                    @object = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<Model> array = new List<Model>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Model.DeserializeModel(item));
                    }
                    data = array;
                    continue;
                }
            }
            return new ListModelsResponse(@object, data);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ListModelsResponse FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeListModelsResponse(document.RootElement);
        }
    }
}
