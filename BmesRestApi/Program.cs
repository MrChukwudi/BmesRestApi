//Setting up Our API Application Builder
using System.Configuration;
using BmesRestApi.Database;
using BmesRestApi.Infrastructure;
using BmesRestApi.Models.Shared;
using BmesRestApi.Repositories;
using BmesRestApi.Repositories.Implementations;
using BmesRestApi.Services;
using BmesRestApi.Services.Implementations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();


// Creating Our Swagger Documentation
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Building Materials E-Store", Version = "v1" });

    //Configuring Swagger for Authenticatication:
    c.AddSecurityDefinition("Bearer",
        new OpenApiSecurityScheme
        {
            Description = "JWT Authorization header using the Bearer scheme.",
            Type = SecuritySchemeType.Http,
            Scheme = "bearer"
        });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }
            }, new List<string>()
        }
    });



});


//Adding Services for Memory Cahching and Sessions <> Remember to go and instruct your App to Use Session:
builder.Services.AddMemoryCache();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();






//Registering/Adding Our DbContext Class Service:
builder.Services.AddDbContext<BmesDbContext>(options =>
    options.UseSqlite(builder.Configuration["Data:BmesApi:ConnectionString"]));



//Registering/Adding Our IdentityDbContext Class Service:
builder.Services.AddDbContext<BmesIdentityDbContext>(options =>
    options.UseSqlite(builder.Configuration["Data:BmesIdentity:ConnectionString"]));
//Adding Identity Service to our project, and directing it to make use of EntityFramework
builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<BmesIdentityDbContext>();

//Registering our Extension Method for Adding the JWT Auth:
builder.Services.AddJwtAuth(builder.Configuration);









//Adding/Registering my Repository <==> Interface Pair services
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IBrandRepository, BrandRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<ICartRepository, CartRepository>();
builder.Services.AddTransient<ICartItemRepository, CartItemRepository>();
builder.Services.AddTransient<IAddressRepository, AddressRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<IPersonRepository, PersonRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<IOrderItemRepository, OrderItemRepository>();
builder.Services.AddTransient<IAuthRepository, AuthRepository>();


//Registering our Services and their Interfaces
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IBrandService, BrandService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ICatalogueService, CatalogueService>();
builder.Services.AddTransient<ICartService, CartService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<ICheckoutService, CheckoutService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();




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

app.UseSession();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();

