//Setting up Our API Application Builder
using BmesRestApi.Database;
using BmesRestApi.Repositories;
using BmesRestApi.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Registering/Adding Our DbContext Class Service:
builder.Services.AddDbContext<BmesDbContext>(options =>
    options.UseSqlite(builder.Configuration["Data:BmesApi:ConnectionString"]));


//Adding/Registering my Repository <==> Interface Pair services
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IBrandRepository, BrandRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();


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

app.UseAuthorization();

app.MapControllers();

app.Run();

