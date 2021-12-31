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
    }
}