using ProtoBuf.Grpc.Configuration;

namespace Test.ProtobufNet.Protobuf
{
    [Service]
    public interface IRpcService
    {
        [Operation]
        Task<Model> GetModel();
        [Operation]
        Task<Model<string>> GetModelString();
        [Operation]
        Task<string> GetString();
    }
}
