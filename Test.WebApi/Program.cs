using DapperFactory.Application.Interfaces;
using DapperFactory.Domain.Data;
using DapperFactory.Domain.Entities.Enums;
using DapperFactory.Domain.Factory;
using DapperFactory.Infrastructure.FactorySelector;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var mySqlFactory = DbFactorySelector.GetConnection(DBType.MySQL, "ConnectionString", "AnaMakine");

builder.Services.AddSingleton<IDapperFactory>(mySqlFactory);

var postgreSQLFactory = DbFactorySelector.GetConnection(DBType.PostgreSQL, "ConnectionString", "AnaMakine");

builder.Services.AddSingleton<IDapperFactory>(postgreSQLFactory);

builder.Services.AddScoped<IDapperMethods, DapperMethods>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
