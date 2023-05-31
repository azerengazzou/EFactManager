
using GatewayAPI;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Values;

var builder = WebApplication.CreateBuilder(args);

Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at http://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
    builder =>
    {
        builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
    });
});

builder.Services.AddAuthentication()
  .AddJwtBearer("Bearer", options =>
  {
      options.Authority = "https://localhost:7203";
      options.Audience = "https://localhost:7287";
      options.TokenValidationParameters.ValidateIssuerSigningKey = false;
      options.TokenValidationParameters.ValidateAudience = false;
      options.TokenValidationParameters.ValidateIssuer = false;
      options.RequireHttpsMetadata = false;
  });

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
    var app = builder.Build();
    app.UseCors("AllowAll");

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

app.UseAuthentication();
app.UseMiddleware<JwtRolesMiddleware>();
app.UseAuthorization();
app.UseHttpsRedirection();

app.UseOcelot();
app.MapControllers();
app.Run();
