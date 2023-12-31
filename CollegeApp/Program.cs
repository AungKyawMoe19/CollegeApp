using CollegeApp.MyLogging;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddLog4Net();


#region Serilog
//Log.Logger = new LoggerConfiguration()
//.MinimumLevel.Information()
//.WriteTo.File("Log/log.txt", rollingInterval: RollingInterval.Minute)
//.CreateLogger();

////use this line to override the built-in loggers
//builder.Host.UseSerilog();

////use serilog along with built-in loggers
//builder.Logging.AddSerilog();
#endregion

// Add services to the container.


builder.Services.AddControllers(options => options.ReturnHttpNotAcceptable = true).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMyLogger, LogToDB>();
//builder.Services.AddSingleton<IMyLogger, LogToServerMemory>();
//builder.Services.AddTransient<IMyLogger, LogToServerMemory>();


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
