using ProtoBuf;

namespace Test.ProtobufNet.Protobuf
{
    [ProtoContract]
    public class Model
    {
        [ProtoMember(1)]
        public int Int { get; set; }
        [ProtoMember(2)]
        public long Long { get; set; }
        [ProtoMember(3)]
        public int? IntNullable { get; set; }
        [ProtoMember(4)]
        public long? LongNullable { get; set; }
        [ProtoMember(5)]
        public required string String { get; set; }
        [ProtoMember(6)]
        public string? StringNullable { get; set; }
        [ProtoMember(7)]
        public Guid Guid { get; set; }
        [ProtoMember(8)]
        public Guid? GuidNullable { get; set; }
        [ProtoMember(11)]
        public required List<int> List { get; set; }
        [ProtoMember(12)]
        public required Dictionary<string, int> Dictionary { get; set; }
        [ProtoMember(9)]
        public required Model<bool> ModelBool { get; set; }
        [ProtoMember(10)]
        public Model<bool>? ModelBoolNullable { get; set; }
    }
}