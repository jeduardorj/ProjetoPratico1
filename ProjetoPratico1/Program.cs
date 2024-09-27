using Microsoft.EntityFrameworkCore;
using ProjetoPratico1.Data;


        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<Context>
            (options => options.UseMySql(
                "server=localhost; initial catalog=PROJETO_PRATICO; uid=root;pwd=123456",
                serverVersion:Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.38-mysql")));

        var app = builder.Build();


        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Usuarios}/{action=Index}/{id?}");

        app.Run();
    
