using System.Collections.Generic;

namespace DesignPattern.Pattern.ProtoType
{
    public class ProtoTypeFactory
    {
        private static List<ProtoType> _protoTypes = new List<ProtoType>();

        public ProtoTypeFactory()
        {
            _protoTypes.Add(new ConcreteProtoType1());
            _protoTypes.Add(new ConcreteProtoType2());
        }

        public ProtoType Create<T>() where T : ProtoType
        {
            return _protoTypes.Find(pt => pt is T).Clone();
        }
    }
}