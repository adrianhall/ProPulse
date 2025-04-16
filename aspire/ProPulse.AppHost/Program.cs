var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql")
                 .WithLifetime(ContainerLifetime.Persistent)
                 .WithDbGate();

var db = sql.AddDatabase("propulse-db");

var storage = builder.AddAzureStorage("storage")
                     .RunAsEmulator();
                     
builder.Build().Run();
