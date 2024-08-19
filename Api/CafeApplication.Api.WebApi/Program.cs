using CafeApplication.Database.Framework;
using CafeApplication.Model.Models.Shared;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var appSettings = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettings);
var setting = appSettings.Get<AppSettings>();
appSettings.Bind(setting);

builder.Services.AddSingleton<AppSettings>(setting);

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseMySql(setting.DefaultConnection, ServerVersion.AutoDetect(setting.DefaultConnection));
});


var app = builder.Build();

// Configure the HTTP request pipeline.

using (var serviceScope = app.Services.GetService<IServiceScopeFactory>()?.CreateScope())
{
    if (serviceScope != null)
    {
        DatabaseContext cont = serviceScope.ServiceProvider.GetRequiredService<DatabaseContext>();
        if (cont.Database.GetPendingMigrations().Count() > 0)
        {
            cont.Database.Migrate();
        }
    }
}

app.UseAuthorization();

app.MapControllers();

app.Run();
