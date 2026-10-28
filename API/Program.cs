using API.Data;
using Microsoft.EntityFrameworkCore;

// const string ClientCorsPolicy = "ClientCorsPolicy";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

 builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// var allowedOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>() ?? [];
// builder.Services.AddCors(options =>
//     options.AddPolicy(ClientCorsPolicy, policy =>
//         policy.WithOrigins(allowedOrigins).AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();

// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }

// app.UseHttpsRedirection();
// app.UseCors(ClientCorsPolicy);
// app.UseAuthorization();

app.MapControllers();

app.Run();
