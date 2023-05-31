namespace Net7._5___Verschiedenes
{
    public static class ReadonlyInstanceMembers
    {
        public static void Run()
        {
            MyStruct myStruct = new MyStruct(13);
            Method(myStruct);
        }

        static void Method(in MyStruct myStruct)
        {
            var number = myStruct.GetNumber();
        }
    }

    struct MyStruct
    {
        private int number;

        public MyStruct(int number)
        {
            this.number = number;
        }

        public readonly int GetNumber()
        {
            return number;
        }
    }
}