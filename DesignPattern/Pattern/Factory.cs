using System;

namespace DesignPattern.Pattern
{
    // Entrust a creation of a class to a class called  "Factory"
    // Get creation of children classes from Type abstract Class done by a class called "FactoryType"
    public class Factory
    {
        public static void FactoryTest()
        {
            Factory f = new Factory();
            Type t1 = f.createType("A");
            Type t2 = f.createType("B");
        }
        
        public Type createType(string type)
        {
            TypeFactory factory = new TypeFactory();
            Type returnType = factory.createType(type);
            return returnType;
        }
    }

    public abstract class Type
    {
    }

    public class TypeA : Type
    {
        public TypeA()
        {
            Console.WriteLine("Type A creation");
        }
    }

    public class TypeB : Type
    {
        public TypeB()
        {
            Console.WriteLine("Type B creation");
        }
    }

    public class TypeC : Type
    {
        public TypeC()
        {
            Console.WriteLine("Type C creation");
        }
    }

    // This is a factory class to create all children classes from Type abstract class
    public class TypeFactory
    {
        public Type createType(string type)
        {
            Type returnType = null;
            switch (type)
            {
                case "A":
                    returnType = new TypeA();
                    break;
                case "B":
                    returnType = new TypeB();
                    break;
                case "C":
                    returnType = new TypeC();
                    break;
            }

            return returnType;
        }
    }
}