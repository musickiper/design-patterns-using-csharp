using System;

namespace DesignPattern.Pattern.Singleton
{
    public class SingletonTest
    {
        public static void Test()
        {
            // Singleton s = new Singleton(); // Not available
            SingletonClass s = SingletonClass.Instance();
            SingletonClass s2 = SingletonClass.Instance();
            Console.WriteLine((bool) (s.GetHashCode() == s2.GetHashCode())); // True
        }
    }
}