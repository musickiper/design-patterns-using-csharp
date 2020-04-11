namespace DesignPattern.Pattern.ProtoType
{
    public class ProtoTypeTest
    {
        public static void Test()
        {
            ProtoTypeFactory protoTypeFactory = new ProtoTypeFactory();
            var concreteProtoType1 = protoTypeFactory.Create<ConcreteProtoType1>();
            var concreteProtoType2 = protoTypeFactory.Create<ConcreteProtoType2>();
        }
    }
}