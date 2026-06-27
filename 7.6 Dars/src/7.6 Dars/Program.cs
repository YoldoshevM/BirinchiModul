var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Development emas, har doim ishlaydi
app.MapOpenApi();

// app.UseHttpsRedirection(); // Dockerda https yo'q, shu qatorni o'chiring

app.UseAuthorization();

app.MapControllers();

app.Run();