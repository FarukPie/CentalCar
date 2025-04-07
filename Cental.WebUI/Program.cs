using Cental.BusinessLayer.Abstract;
using Cental.BusinessLayer.Concreate;
using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Concreate;
using Cental.DataAccesLayer.Context;
using Cental.DataAccesLayer.Repostories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// about service  gordugun zaman aboutmanager sınıfından bır nesne ornegı al ve ıslemı onunla yap

builder.Services.AddDbContext<CentalContext>();
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepostory<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));



builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
