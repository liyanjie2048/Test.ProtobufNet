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

        [ProtoMember(9)]
        public DateTime DateTime { get; set; }

        [ProtoMember(10)]
        public DateTime? DateTimeNullable { get; set; }

        [ProtoMember(11)]
        public DateTimeOffset DateTimeOffset { get; set; }

        [ProtoMember(12)]
        public DateTimeOffset? DateTimeOffsetNullable { get; set; }

        [ProtoMember(13)]
        public DateOnly DateOnly { get; set; }

        [ProtoMember(14)]
        public DateOnly? DateOnlyNullable { get; set; }

        [ProtoMember(15)]
        public TimeOnly TimeOnly { get; set; }

        [ProtoMember(16)]
        public TimeOnly? TimeOnlyNullable { get; set; }

        [ProtoMember(17)]
        public required List<int> List { get; set; }

        [ProtoMember(18)]
        public required IReadOnlyList<int> ReadOnlyList { get; set; }

        [ProtoMember(19)]
        public required Dictionary<string, int> Dictionary { get; set; }

        [ProtoMember(20)]
        public required IReadOnlyDictionary<string, int> ReadOnlyDictionary { get; set; }

        [ProtoMember(21)]
        public required Model<bool> ModelBool { get; set; }

        [ProtoMember(22)]
        public Model<bool>? ModelBoolNullable { get; set; }

        [ProtoMember(23)]
        public (string Name, double Value) Turple { get; set; }
    }
}