var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Presentation>("presentation").WithHttpsEndpoint();

builder.Build().Run();
