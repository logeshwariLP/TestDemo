using AutoMapper;
using Confluent.Kafka;
using Microsoft.EntityFrameworkCore;
using SearchCifApi;
using SearchCifApi.DbContexts;
using SearchCifApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(connectionString));

IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<ICifUserRepository, CifUserRepository>();

var clientConfig = new ClientConfig(new ClientConfig
{
    BootstrapServers = builder.Configuration["Kafka:ClientConfigs:BootstrapServers"]
});
var consumerConfig = new ConsumerConfig(clientConfig)
{
    GroupId = "test_group",
    EnableAutoCommit = true,
    AutoOffsetReset = AutoOffsetReset.Earliest,
    StatisticsIntervalMs = 5000,
    SessionTimeoutMs = 6000
};

builder.Services.AddSingleton(consumerConfig);



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
