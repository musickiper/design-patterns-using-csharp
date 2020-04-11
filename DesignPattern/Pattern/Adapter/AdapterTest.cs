using System;

namespace DesignPattern.Pattern.Adapter
{
    public class AdapterTest
    {
        public static void Test()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter, client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}