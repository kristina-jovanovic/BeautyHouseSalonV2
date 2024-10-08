using Common.Communication;
using Common.Configuration;
using Common.Domain;
using DataAccessLayer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebAPI.Mappings;
using WebAPI.Repositories;
using Server;
using DataAccessLayer.Repositories.DBBroker;
using DBBroker;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//dodata konfiguracija 
builder.Services.AddSingleton<IAppConfiguration, WebApiConfiguration>();
builder.Services.AddSingleton<EmailSender>();
//injecting repositories
builder.Services.AddScoped<Broker>(provider =>
{
	return new Broker(provider.GetRequiredService<IAppConfiguration>());
}); // Registracija Brokera
builder.Services.AddScoped<IRepository<IEntity>>(provider =>
{
	//var broker = provider.GetRequiredService<Broker>();
	return new RepositoryDBB(provider.GetRequiredService<Broker>());
});
builder.Services.AddScoped<ITokenRepository, TokenRepository>();

builder.Services.AddScoped<Server.Controller>(); // Registracija Controllera

// injecting profiles with automapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

//adding jwt bearer and authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
	{
		ValidateIssuer = true,
		ValidateAudience = true,
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,
		ValidIssuer = builder.Configuration["Jwt:Issuer"],
		ValidAudience = builder.Configuration["Jwt:Audience"],
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
	});

//allowing other apps to connect
builder.Services.AddCors(o =>
{
	o.AddPolicy("MyPolicy", builder =>
	{
		builder.AllowAnyOrigin()
			   .AllowAnyMethod()
			   .AllowAnyHeader();
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

// Ovo omogucava CORS politiku, odobri pristup svakoj metodi za aplikaciju sa porta 3000
//app.UseCors(
//		options => options.WithOrigins("http://localhost:3000").AllowAnyMethod()
//	);
app.UseCors("MyPolicy"); //MyPolicy dodata, omogucava pristup bilo odakle, ka bilo kojoj metodi i uz bilo koji header

app.UseAuthentication(); //dodata autentikacija
app.UseAuthorization();

app.MapControllers();

app.Run();
