using Microsoft.AspNetCore.Server.Kestrel.Core;

using ProtoBuf.Grpc.Server;
using ProtoBuf.Meta;

using Test.ProtobufNet.Grpc;

RuntimeTypeModel.Default.AddDateTimeOffsetSurrogate();
RuntimeTypeModel.Default.AddDateOnlySurrogate();
RuntimeTypeModel.Default.AddTimeOnlySurrogate();

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(10042, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http2;
    });
});

builder.Services.AddCodeFirstGrpc();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.MapGrpcService<RpcService>();

app.Run();
