namespace OpenSocio.Common.Extensions
{
    public static class ObjectExtensions
    {
        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }

        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static bool IsNotNullOrEmpty(this object obj)
        {
            return obj.IsNull() && obj.ToString().IsNotEmpty();
        }

        public static bool IsNullOrEmpty(this object obj)
        {
            return obj.IsNull() || obj.ToString().IsEmpty();
        }
    }
}