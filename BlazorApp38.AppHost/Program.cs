var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorApp38>("webapp");

builder.Build().Run();
