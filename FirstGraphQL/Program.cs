var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();
var app = builder.Build();
app.MapGraphQL();
app.MapGet("/", () => "Hello World!");

app.Run();

public class Query
{
    public string SayHello(string name = "GraphQL") => $"Hello,{name} !";
}