using Net7._1___Records;

namespace Net7._5___Verschiedenes
{
    public static class TargetTypedNew
    {
        public static void Run()
        {
            Person person = new("timo", 32) { Address = "" };
            
            Method(new object());
        }

        public static void Method(object obj)
        {
            
        }
    }
}