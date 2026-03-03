using BaseBackend.Application;
using BaseBackend.Infrastructure;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

var devCorsPolicy = "_devCors";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: devCorsPolicy,
        policy =>
        {
            policy.WithOrigins("http://localhost:5173");
        });
});

builder.Services.AddOpenApi();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddEventListeners(ApplicationAssemblyReference.Assembly);
builder.Services.AddControllers();

builder.Services.AddSwaggerGen(o =>
{
    o.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(devCorsPolicy);
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();
