namespace DesignPattern.Pattern.ProtoType
{
    public class ConcreteProtoType2 : ProtoType
    {
        public override ProtoType Clone()
        {
            return (ConcreteProtoType2) this.MemberwiseClone();
        }
    }
}