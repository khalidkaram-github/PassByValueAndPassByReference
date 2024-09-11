namespace PassByValueAndPassByReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            //PassByValue
            PassByValue(x);
            Console.WriteLine(x);

            //
            PassByRefrence(ref x);
            Console.WriteLine(x);
        }

        static void PassByValue(int x)
        {
            x = 90;
        }

        static void PassByRefrence(ref int x)
        {
            x = 100;
        }


    }
}
