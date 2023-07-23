using ProtoBuf;

namespace Test.ProtobufNet.Protobuf
{
    [ProtoContract]
    public class Model<TValue>
    {
        [ProtoMember(1)]
        public required TValue Value { get; set; }
    }
}
