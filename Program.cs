using Microsoft.EntityFrameworkCore;
using TEST.API.DB;
using TEST.API.Integration.Implementation;
using TEST.API.Integration.Payload;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("StudentDB");

builder.Services.AddDbContext<StudentDbContext>(opt => opt.UseSqlServer(connectionString));
// builder.Services.AddDbContext<StudentDbContext>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddControllers();
builder.Services.Configure<ProductConfig>(builder.Configuration.GetSection(nameof(ProductConfig)));
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
