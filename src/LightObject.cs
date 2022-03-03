using System.Text.Encodings.Web;
using System.Text.Json;
using Mapster;

namespace LightExtension
{
    public static class LightObject
    {
        public static bool IsNull(this object source)
        {
            return source == null;
        }

        public static TSource MapAs<TSource>(this object source)
        {
            return source.Adapt<TSource>();
        }

        public static void MapTo<TSource, TDestination>(this TSource source, TDestination destination) where TDestination : class
        {
            source.Adapt(destination);
        }

        public static bool Is(this object source, object destination)
        {
            return source == destination;
        }

        // 序列化
        public static string Serialize(this object source, bool writeIndented = false)
        {
            return JsonSerializer.Serialize(source, new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = writeIndented
            });
        }

        public static string Serialize(this object source, JsonSerializerOptions options)
        {
            return JsonSerializer.Serialize(source, options);
        }
    }
}
