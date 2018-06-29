namespace OpenSocio.Common
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
    }
}