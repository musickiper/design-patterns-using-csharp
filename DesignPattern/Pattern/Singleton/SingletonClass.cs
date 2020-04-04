using System;

namespace DesignPattern.Pattern.Singleton
{
    public class SingletonClass
    {
        private static SingletonClass _instance;

        // Set the default constructor as private to prevent calling from outside of this class scope
        private SingletonClass()
        {
        }

        // When this function called first time, initialize _instance, and return it
        // From the second time, return the instance initialized at the first time (Re-use it)
        public static SingletonClass Instance()
        {
            _instance = _instance ?? new SingletonClass();
            return _instance;
        }
    }
}