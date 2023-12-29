//Setting up Our API Application Builder
using BmesRestApi.Database;
using BmesRestApi.Repositories;
using BmesRestApi.Repositories.Implementations;
using BmesRestApi.Services;
using BmesRestApi.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


// Creating Our Swagger Documentation
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Building Materials E-Store", Version = "v1" });
});

//Registering/Adding Our DbContext Class Service:
builder.Services.AddDbContext<BmesDbContext>(options =>
    options.UseSqlite(builder.Configuration["Data:BmesApi:ConnectionString"]));


//Adding/Registering my Repository <==> Interface Pair services
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IBrandRepository, BrandRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();


//Registering our Services and their Interfaces
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IBrandService, BrandService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ICatalogueService, CatalogueService>();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Building Materials E-Store V1");
    });
}

app.UseAuthorization();

app.MapControllers();

app.Run();

