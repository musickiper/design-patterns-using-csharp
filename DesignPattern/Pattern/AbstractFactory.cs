using System;

namespace DesignPattern.Pattern
{
    // 서로 관련 있는 객체들을 통째로 묶에서 팩토리 클래스를 만들고, 이들 팩토리를 조건에 따라서 생성하도록 다시 팩토리를 만들어서 객체를 생성 
    public class AbstractFactory
    {
        public static void AbstractFactoryTest()
        {
            FactoryOfComputerFactory factoryOfComputerFactory = new FactoryOfComputerFactory();
            factoryOfComputerFactory.createComputer("LG");
        }
    }

    public interface Keyboard
    {
    }

    public class LGKeyboard : Keyboard
    {
        public LGKeyboard()
        {
            Console.WriteLine("LG Keyboard creation");
        }
    }

    public class SamsungKeyboard : Keyboard
    {
        public SamsungKeyboard()
        {
            Console.WriteLine("Samsung Keyboard creation");
        }
    }

    public interface Mouse
    {
    }

    public class LGMouse : Mouse
    {
        public LGMouse()
        {
            Console.WriteLine("LG Mouse creation");
        }
    }

    public class SamsungMouse : Mouse
    {
        public SamsungMouse()
        {
            Console.WriteLine("Samsung Mouse creation");
        }
    }

    public interface ComputerFactory
    {
        Keyboard createKeyboard();
        Mouse createMouse();
    }

    public class SamsungComputerFactory : ComputerFactory
    {
        public Keyboard createKeyboard()
        {
           return new SamsungKeyboard(); 
        }

        public Mouse createMouse()
        {
            return new SamsungMouse();
        }
    }

    public class LGComputerFactory : ComputerFactory
    {
        public Keyboard createKeyboard()
        {
           return new LGKeyboard();
        }

        public Mouse createMouse()
        {
            return new  LGMouse();
        }
    }

    public class FactoryOfComputerFactory
    {
        public void createComputer(string type)
        {
            ComputerFactory computerFactory = null;
            switch (type)
            {
                case "LG":
                    computerFactory = new LGComputerFactory();
                    break;
                case "Samsung":
                    computerFactory = new SamsungComputerFactory();
                    break;
            }

            computerFactory.createKeyboard();
            computerFactory.createMouse();
        }
    }
}