using IMTC.CodeTest.Application.Contracts;
using IMTC.CodeTest.Application.Features.Bond;
using IMTC.CodeTest.Application.Services;
using IMTC.CodeTest.Calculators;
using IMTC.CodeTest.Core.Services;
using IMTC.CodeTest.Indices.Services;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

builder.Services.AddTransient<IBondService, BondService>();
builder.Services.AddTransient<IYtwCalculator, YtwCalculator>();
builder.Services.AddTransient<IImtcCalculator, ImtcCalculator>();
builder.Services.AddTransient<ITimeService, TimeService>();
builder.Services.AddTransient<IIndexProvider, IndexProvider>();


// Explicitly provide the assembly where MediatR handlers are defined
builder.Services.AddMediatR(typeof(GetBondHandler).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
