using Test.ProtobufNet.Protobuf;

namespace Test.ProtobufNet.Grpc
{
    public class RpcService : IRpcService
    {
        public Model GetModel() => new()
        {
            Int = 9,
            Long = 99,
            IntNullable = null,
            LongNullable = null,
            String = "String",
            StringNullable = null,
            Guid = Guid.NewGuid(),
            GuidNullable = null,
            DateTime = DateTime.Now,
            DateTimeNullable = null,
            DateTimeOffset = DateTimeOffset.Now,
            DateTimeOffsetNullable = null,
            DateOnly = DateOnly.MaxValue,
            DateOnlyNullable = DateOnly.MaxValue,
            TimeOnly = TimeOnly.MaxValue,
            TimeOnlyNullable = TimeOnly.MaxValue,
            List = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            ReadOnlyList = new List<int> { 1, 2, 3 },
            Dictionary = new() { ["1"] = 1, ["2"] = 2, ["3"] = 4, },
            ReadOnlyDictionary = new Dictionary<string, int> { ["1"] = 1, },
            ModelBool = new() { Value = true },
            ModelBoolNullable = null,
            Turple = ("Name", 0.123456),
        };
        public Model<string> GetModelString(string s) => new() { Value = s };
        public IEnumerable<Guid> GetEnumerable(IEnumerable<Guid> enumerable) => enumerable;
        public IDictionary<string, Guid> GetDictionary(IDictionary<string, Guid> dictionary) => dictionary;
        public NullableResponse<Model> GetNull() => (Model?)null;
        public string? GetString(string? s) => s;
        public bool? GetBool(bool? b) => b;
        public double? GetDouble(double? d) => d;
        public decimal? GetDecimal(decimal? d) => d;
        public Guid? GetGuid(Guid? id) => id;
        public DateTime? GetDateTime(DateTime? dateTime) => dateTime;
        public DateTimeOffset? GetDateTimeOffset(DateTimeOffset? dateTimeOffset) => dateTimeOffset;
        public DateOnly? GetDateOnly(DateOnly? date) => date;
        public TimeOnly? GetTimeOnly(TimeOnly? time) => time;
        public string MultiParams(bool b, int i, DateTimeOffset? d) => $"{b}+{i}+{(d ?? DateTimeOffset.MinValue):yyyy/MM/dd HH:mm:ss}";
    }
}
