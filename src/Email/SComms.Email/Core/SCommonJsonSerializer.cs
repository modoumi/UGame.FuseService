using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SComms.Email.Core;

public class SCommonJsonSerializer
{
    public static readonly JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        ReferenceHandler = ReferenceHandler.IgnoreCycles
    };
    public static string Serialize(object obj) => JsonSerializer.Serialize(obj, SerializerOptions);
    public static string Serialize<T>(T obj) => JsonSerializer.Serialize<T>(obj, SerializerOptions);
    public static object Deserialize(string json, Type type) => JsonSerializer.Deserialize(json, type, SerializerOptions);
    public static T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json, SerializerOptions);
}