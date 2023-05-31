using EFactManagerAPI;
using EFactManagerAPI.Data;
using EFactManagerAPI.Models;
using EFactManagerAPI.Repository;
using EFactManagerAPI.Repository.IRepository;
using EFactManagerAPI.Services;
using EFactManagerAPI.Services.IServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Repositorys
builder.Services.AddScoped<IMessageRepository, MessageRepository>();
builder.Services.AddScoped<IFileRepository, FileRepository>();
builder.Services.AddScoped<IRecordRepository, RecordRepository>();
builder.Services.AddScoped<IZoneRepository, ZoneRepository>();
builder.Services.AddScoped<IFieldRepository, FieldRepository>();
builder.Services.AddScoped<IEfactFileContentRepository, EfactFileContentRepository>();
builder.Services.AddScoped<IZoneErrorRepository, ZoneErrorRepository>();
//services
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IBackUpFileService, BackUpFileService>();
builder.Services.AddScoped<ISplitFileNoErrorService, SplitFileNoErrorService>();
builder.Services.AddScoped<ISplitFileErrorService, SplitFileErrorService>();

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});

builder.Services.AddAutoMapper(typeof(MappingConfig)); //Configuration de l'automapper
builder.Services.AddControllers(option =>
{

// option.ReturnHttpNotAcceptable=true;
}).AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
}).AddXmlDataContractSerializerFormatters();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();
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



var httpClientHandler = new HttpClientHandler
{
    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
};
var httpClient = new HttpClient(httpClientHandler);




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseCors("AllowAll");


app.UseHttpsRedirection();

app.MapControllers();

app.Run();
