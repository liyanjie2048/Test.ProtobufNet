using ProtoBuf;

namespace Test.ProtobufNet.Protobuf;

[ProtoContract]
public class NullableResponse<TValue>
{
    [ProtoMember(1)]
    public TValue? Value { get; set; }

    public static implicit operator NullableResponse<TValue>(TValue? value) => new() { Value = value };
}
