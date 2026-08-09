using Microsoft.EntityFrameworkCore;
using Toko.EFCore.Application.Context;
using Toko.EFCore.Application.Services;
using Toko.EFCore.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<
    ITokoEFCoreDBContext, 
    TokoEFCoreDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped<IIllustratorService, IllustratorService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<TokoEFCoreDBContext>();
    dbContext.Database.EnsureCreated();
};

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
