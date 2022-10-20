
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApplication1.Modal
{

    public class Book
    {
        [JsonPropertyName("id")]
        // for example if we want to use book_id instead of id so JaonPropertyName is used
        public int book_id
        {
            get; set;
        }
        [JsonPropertyName("name")]
        public string name
        {
            get; set;
        }
        [JsonPropertyName("image")]
        public string image
        {
            get; set;
        }

        //for write data in to json
        public override string ToString()
        {
            return JsonSerializer.Serialize<Book>(this);

        }
    }
}