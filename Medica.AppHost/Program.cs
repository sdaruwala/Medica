var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Medica_API>("medica-api");

builder.AddProject<Projects.Medica_Client>("medica-client")
    .WithReference(api)
    .WithExternalHttpEndpoints();

builder.Build().Run();
