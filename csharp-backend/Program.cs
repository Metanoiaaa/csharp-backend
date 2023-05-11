using Microsoft.EntityFrameworkCore;
using mijnDBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MijnDatabaseContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    // options.UseSqlServer("server=localhost;port=3306;user=root;password=;database=eindopdracht_bbq_recepten");
}
);
var app = builder.Build();

// Prevent frond-end from getting CORS-errors by allowing requests from anywhere
app.UseCors(policy => policy
.AllowAnyMethod()
.AllowAnyHeader()
.SetIsOriginAllowed(origin => true)
.AllowCredentials());

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

