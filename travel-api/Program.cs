using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using travel_api.Data;
using travel_api.Interfaces;
using travel_api.Migrations;
using travel_api.Models;
using travel_api.Repository;
using travel_api.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddAuthentication(x =>
//{
//    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(options => { 
// options.TokenValidationParameters = new TokenValidationParameters
// {

// }
//})


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IDestinationServices, DestinationServices>();
builder.Services.AddScoped<IHotelServices, HotelServices>();
builder.Services.AddScoped<IBookingServices, BookingServices>();

builder.Services.AddTransient<Seed>();
builder.Services.AddDbContext<APIContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("travel-db")));

var app = builder.Build();

if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<Seed>();
        service.SeedDataContext();
    }
}

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
