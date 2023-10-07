using ProtoBuf.Grpc.Configuration;

namespace Test.ProtobufNet.Protobuf
{
    [Service]
    public interface IRpcService
    {
        [Operation] Model GetModel();
        [Operation] Model<string> GetModelString(string s);
        [Operation] IEnumerable<Guid> GetEnumerable(IEnumerable<Guid> enumerable);
        [Operation] IDictionary<string, Guid> GetDictionary(IDictionary<string, Guid> dictionary);
        [Operation] NullableResponse<Model> GetNull();
        [Operation] string? GetString(string? s);
        [Operation] bool? GetBool(bool? b);
        [Operation] double? GetDouble(double? d);
        [Operation] decimal? GetDecimal(decimal? d);
        [Operation] Guid? GetGuid(Guid? id);
        [Operation] DateTime? GetDateTime(DateTime? dateTime);
        [Operation] DateTimeOffset? GetDateTimeOffset(DateTimeOffset? dateTimeOffset);
        [Operation] DateOnly? GetDateOnly(DateOnly? date);
        [Operation] TimeOnly? GetTimeOnly(TimeOnly? time);
        [Operation] string MultiParams(bool b, int i, DateTimeOffset? s);
    }
}
