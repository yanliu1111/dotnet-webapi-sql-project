using System.Text.Json.Serialization;

namespace dotnetproject.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}
// enum works like a list of options, but it's not a list. It's a type.