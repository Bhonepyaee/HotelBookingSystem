namespace HotelBookinSystem.WindowForm.Exrtensions;

public static class DevCode
{
    public static bool IsNullOrEmpty(this string str) =>
        string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);

    public static string ToJson(this object obj) =>
        JsonConvert.SerializeObject(obj, Formatting.Indented);

    public static T ToObject<T>(this string jsonStr) => JsonConvert.DeserializeObject<T>(jsonStr)!;
}
