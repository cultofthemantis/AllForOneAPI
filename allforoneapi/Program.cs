
using allforoneapi.Controllers;
using allforoneapi.Service;
using allforoneapi.Services;



var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<AddTwoService>();
builder.Services.AddScoped<CompareService>();
builder.Services.AddScoped<GuessItService>();
builder.Services.AddScoped<OddOrEvenService>();
builder.Services.AddScoped<MagicEightBallService>();
builder.Services.AddScoped<RestaurantPickerService>();
builder.Services.AddScoped<ReverseAlphabetService>();
builder.Services.AddScoped<ReverseIntService>();
builder.Services.AddScoped<WakeUpService>();
builder.Services.AddScoped<MadLibService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVite",
        policy =>
        {
            policy.WithOrigins()
                  .AllowAnyHeader()
                  
                  .AllowAnyOrigin()
                  
                  .AllowAnyMethod();

        });
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowVite");
app.MapControllers();


app.Run();

