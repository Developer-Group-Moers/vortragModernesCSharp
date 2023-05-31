namespace Net7._5___Verschiedenes
{
    public static class StaticAbstractsInInterfaces
    {
        public static void Run()
        {
            
        }
    }

    class MyInt : INumber<MyInt>
    {
        private int value;
        public static MyInt operator +(MyInt left, MyInt right)
        {
            return new MyInt() { value = left.value + right.value };
        }
    }

    public interface INumber<T> where T : INumber<T>
    {
        static abstract T operator+(T left, T right);
    }
}