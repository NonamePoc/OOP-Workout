using Newtonsoft.Json;

namespace Lab4Shaban.Lib;

public static class JsonHelper
{
    public static string ConvertToJson(this Ray ray)
    {
        return JsonConvert.SerializeObject(ray);
    }
}