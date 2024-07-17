namespace Extension_Methods_EXP
{
    internal class Exp_Extension_Methods
    {
        public void callExtensionMethods()
        {
            MyClass obj = new MyClass();
            obj.M1();
            obj.M2();
            obj.M3();
            obj.M4();
            obj.M5("abc");
        }
    }
    public class MyClass
    {
        public void M1()
        {
            Console.WriteLine("M1");
        }
        public void M2()
        {
            Console.WriteLine("M2");
        }
        public void M3()
        {
            Console.WriteLine("M3");
        }
    }
    public static class ExtensionClass
    {
        public static void M4(this MyClass obj)
        {
            Console.WriteLine("M4");
        }
        public static void M5(this MyClass obj, string input)
        {
            Console.WriteLine("M5");
        }

    }
}
