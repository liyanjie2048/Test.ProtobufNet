using ProtoBuf.Grpc.ClientFactory;
using ProtoBuf.Meta;

using Test.ProtobufNet.Protobuf;

RuntimeTypeModel.Default.AddDateTimeOffsetSurrogate();
RuntimeTypeModel.Default.AddDateOnlySurrogate();
RuntimeTypeModel.Default.AddTimeOnlySurrogate();

ProtoBuf.Grpc.Client.GrpcClientFactory.AllowUnencryptedHttp2 = true;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCodeFirstGrpcClient<IRpcService>(options =>
{
    options.Address = new Uri("http://localhost:10042");
});

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.MapRazorPages();

app.Run();
