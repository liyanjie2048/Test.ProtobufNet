using Test.ProtobufNet.Protobuf;

namespace Test.ProtobufNet.Grpc
{
    public class RpcService : IRpcService
    {
        public async Task<Model> GetModel()
        {
            await Task.CompletedTask;

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
                List = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                Dictionary = new() { ["1"] = 1, ["2"] = 2, ["3"] = 4, },
                ModelBool = new() { Value = true },
                ModelBoolNullable = null,
            };
        }

        public async Task<Model<string>> GetModelString()
        {
            await Task.CompletedTask;

            return new() { Value = "String" };
        }

        public async Task<string> GetString()
        {
            await Task.CompletedTask;

            return "String";
        }
    }
}
