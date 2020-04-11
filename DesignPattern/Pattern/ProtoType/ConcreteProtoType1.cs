namespace DesignPattern.Pattern.ProtoType
{
    public class ConcreteProtoType1 : ProtoType
    {
        public override ProtoType Clone()
        {
            return (ConcreteProtoType1) this.MemberwiseClone();
        }
    }
}