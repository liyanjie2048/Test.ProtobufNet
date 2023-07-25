using Test.ProtobufNet.Protobuf;

namespace Test.ProtobufNet.Grpc
{
    public class RpcService : IRpcService
    {
        public Model GetModel()
        {
            return new()
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
                //DateOnly = DateOnly.MaxValue,
                //DateOnlyNullable = null,
                //TimeOnly = TimeOnly.MaxValue,
                //TimeOnlyNullable = null,
                List = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                ReadOnlyList = new List<int> { 1, 2, 3 },
                Dictionary = new() { ["1"] = 1, ["2"] = 2, ["3"] = 4, },
                ReadOnlyDictionary = new Dictionary<string, int> { ["1"] = 1, },
                ModelBool = new() { Value = true },
                ModelBoolNullable = null,
            };
        }
        public Model<string> GetModelString()
        {
            return new() { Value = "String" };
        }
        public IEnumerable<Guid> GetEnumerableGuid()
        {
            return new[] { Guid.NewGuid() };
        }
        public NullableResponse<Model> GetNull() => (Model?)null;
        public string GetString(string s) => s;
        public bool GetBool(bool b) => b;
        public decimal GetDecimal(decimal d) => d;
        public Guid GetGuid(Guid id) => id;
        public DateTime GetDateTime(DateTime dateTime) => dateTime;
        public DateTimeOffset GetDateTimeOffset(DateTimeOffset dateTimeOffset) => dateTimeOffset;
        public DateOnly GetDateOnly(DateOnly date) => date;
        public TimeOnly GetTimeOnly(TimeOnly time) => time;
    }
}
