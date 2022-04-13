#if NET20
namespace System
{
    internal static class StringNET20
    {
        public static bool IsNullOrWhiteSpace(string s)
        {
            bool null_ws = false;

            if (s is null) null_ws = true;
            if (s.Length == 0) null_ws = true;
            if (s.Trim() == "") null_ws = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || s[i] == 10 || s[i] == 10) null_ws = true;
                else
                {
                    null_ws = false;
                    break;
                }
            }
            return null_ws;
        }
    }
}
#endif