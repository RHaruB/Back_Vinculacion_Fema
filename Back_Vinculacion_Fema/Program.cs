// test merge
using Back_Vinculacion_Fema.Models.DbModels;
using Back_Vinculacion_Fema.Models.Utilidades;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

#region Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion

#region BD services
builder.Services.AddDbContext<vinculacionfemaContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionTestRobles")));
//options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionTest")));
//options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 
#endregion

#region JWT services
builder.Services.AddAuthorization();
Token.AddJwtAuthentication(builder.Services);
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
