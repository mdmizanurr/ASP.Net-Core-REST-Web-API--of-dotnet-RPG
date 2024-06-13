using System.Text.Json.Serialization;

namespace dotnet_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClas
    {
        Knight = 1, 
        Mage= 2, 
        Cleric = 3
    }
}