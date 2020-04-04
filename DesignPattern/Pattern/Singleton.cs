using System;

namespace DesignPattern.Pattern
{
    public class Singleton
    {
        private static Singleton _instance;

        // Set the default constructor as private to prevent calling from outside of this class scope
        private Singleton()
        {
        }

        // When this function called first time, initialize _instance, and return it
        // From the second time, return the instance initialized at the first time (Re-use it)
        public static Singleton Instance()
        {
            _instance = _instance ?? new Singleton();
            return _instance;
        }

        public static void TestSingleton()
        {
            // Singleton s = new Singleton(); // Not available
            Singleton s = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            Console.WriteLine(s.GetHashCode() == s2.GetHashCode()); // True
        }
    }
}