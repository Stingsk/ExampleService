using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ExampleService.Internal.Configuration;

public class JsonSettings
{
    public static JsonSerializerSettings GetJsonSerializerSettings()
    {
        var serializerSettings = new JsonSerializerSettings {
            ContractResolver = new DefaultContractResolver { NamingStrategy = new DefaultNamingStrategy() },
            Culture = CultureInfo.GetCultureInfo("ru-RU"),
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            DateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss"
        };

        return serializerSettings;
    }
}