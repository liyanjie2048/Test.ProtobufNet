using ProtoBuf.Grpc.Configuration;

namespace Test.ProtobufNet.Protobuf
{
    [Service]
    public interface IRpcService
    {
        [Operation] Model GetModel();
        [Operation] Model<string> GetModelString();
        [Operation] IEnumerable<Guid> GetEnumerableGuid();
        [Operation] NullableResponse<Model> GetNull();
        [Operation] string GetString(string s);
        [Operation] bool GetBool(bool b);
        [Operation] decimal GetDecimal(decimal d);
        [Operation] Guid GetGuid(Guid id);
        [Operation] DateTime GetDateTime(DateTime dateTime);
        [Operation] DateTimeOffset GetDateTimeOffset(DateTimeOffset dateTimeOffset);
        [Operation] DateOnly GetDateOnly(DateOnly date);
        [Operation] TimeOnly GetTimeOnly(TimeOnly time);
    }
}
