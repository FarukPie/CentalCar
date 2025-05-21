using Cental.BusinessLayer.Abstract;
using Cental.BusinessLayer.Concreate;
using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Concreate;
using Cental.DataAccesLayer.Context;
using Cental.DataAccesLayer.Repostories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// about service  gordugun zaman aboutmanager sınıfından bır nesne ornegı al ve ıslemı onunla yap   



builder.Services.AddDbContext<CentalContext>();


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IBannerDal, EfBannerDal>();
builder.Services.AddScoped<IBannerService,BannerManager>();

builder.Services.AddScoped<IBrandDal, EfBrandDal>();
builder.Services.AddScoped<IBrandService,BrandManager>();

builder.Services.AddScoped<ICarDal, EfCarDal>();
builder.Services.AddScoped<ICarService,CarManager>();

builder.Services.AddScoped<IFeatureDal, EfFeaturesDal>();
builder.Services.AddScoped<IFeaturesService, FeatureManager>();

builder.Services.AddScoped<IProcessDal, EfProcessDal>();
builder.Services.AddScoped<IProcessService, ProcessManager>();

builder.Services.AddScoped<IReviewDal, EfReviewDal>();
builder.Services.AddScoped<IReviewService, ReviewManager>();

builder.Services.AddScoped<ITestimonialsDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimaonialManager>();







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
