namespace Net7._5___Verschiedenes
{
    public static class CovariantReturnTypes
    {
        public static void Run()
        {
            
        }

        public class Upper
        {
            public virtual Upper Clone()
            {
                return new Upper();
            }
        }

        public class Lower : Upper
        {
            public override Lower Clone()
            {
                return new Lower();
            }
        }
    }
}