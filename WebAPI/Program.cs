using Common.Communication;
using Common.Configuration;
using Common.Domain;
using DataAccessLayer.Repositories.EFCore;
using DataAccessLayer;
using InfrastructureEF;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebAPI.Configuration;
using WebAPI.Mappings;
using WebAPI.Repositories;
using DataAccessLayer.Repositories.EFCore.KorisnikRepository;
using DataAccessLayer.Repositories.EFCore.UslugaRepository;
using DataAccessLayer.Repositories.EFCore.TipUslugeRepository;
using DataAccessLayer.Repositories.EFCore.ProfilUslugeRepository;
using DataAccessLayer.Repositories.EFCore.ZahtevZaRezTerminaRepository;
using Server;
using DataAccessLayer.Repositories.DBBroker;
using DBBroker;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//injecting DbContext
builder.Services.AddDbContext<BeautyHouseDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("BeautyHouseBazaV2")));

//injecting repositories
builder.Services.AddSingleton<Broker>(); // Registracija Brokera
builder.Services.AddScoped<IRepository<IEntity>>(provider =>
{
	var broker = provider.GetRequiredService<Broker>();
	return new RepositoryDBB(broker);
});
builder.Services.AddScoped<ITokenRepository, TokenRepository>();
builder.Services.AddScoped<IRepository<Korisnik>, KorisnikRepositoryEF>();
builder.Services.AddScoped<IRepository<Usluga>, UslugaRepositoryEF>();
builder.Services.AddScoped<IRepository<TipUsluge>, TipUslugeRepositoryEF>();
builder.Services.AddScoped<IRepository<ProfilRadnika>, ProfilRadnikaRepositoryEF>();
builder.Services.AddScoped<IRepository<ZahtevZaRezervacijuTermina>, ZahtevZaRezervacijuTerminaRepositoryEF>();

//initializing controller
Controller.Initialize(builder.Services.BuildServiceProvider());

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

//dodata konfiguracija 
builder.Services.AddSingleton<IAppConfiguration, WebApiConfiguration>();
builder.Services.AddSingleton<EmailSender>();

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
