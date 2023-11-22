using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.EntityFrameworkCore;
using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.Common.Services;
using Standing_Order_Vat_App.DAL.CoreData_DB;
using Standing_Order_Vat_App.DAL.Directory_DB;
using Standing_Order_Vat_App.DAL.Standing_Order_VAT_DB;
using AspNetCoreHero.ToastNotification;
using Microsoft.AspNetCore.Authentication.Cookies;
using Standing_Order_Vat_App.MvcHelper;
using Standing_Order_Vat_App.DAL.SKNAB;
using Standing_Order_Vat_App.DAL.GB_Register;
using Standing_Order_Vat_App.DAL.SKNANB_LIVE;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie();
//Set Session Timeout. Default is 20 minutes.
builder.Services.AddSession(options =>
{
    
    options.IdleTimeout = TimeSpan.FromDays(2);
});
//builder.Services.AddControllers(config =>
//{
//    config.Filters.Add(new GlobalFilterExample());
//});
builder.Services.AddScoped<filter>();
// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();
builder.Services.AddSession();

//builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
//   .AddNegotiate();

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy.
    options.FallbackPolicy = options.DefaultPolicy;
});


builder.Services.AddDbContext<DirectoryContext>
              (item => item.UseSqlServer
              (builder.Configuration.GetConnectionString("DefaultConnectionDirectory"),
              option => option.CommandTimeout(2000000000)
              )); ;

builder.Services.AddDbContext<CoreDataContext>
              (item => item.UseSqlServer
              (builder.Configuration.GetConnectionString("DefaultConnectionCore"),
              option => option.CommandTimeout(2000000000)));

builder.Services.AddDbContext<Standing_Order_VATContext>
              (item => item.UseSqlServer
              (builder.Configuration.GetConnectionString("DefaultConnectionStanding"),
              option => option.CommandTimeout(2000000000)));

builder.Services.AddDbContext<SKNANBLIVEContext>
              (item => item.UseSqlServer
              (builder.Configuration.GetConnectionString("DefaultConnectionStandings"),
              option => option.CommandTimeout(2000000000)));

builder.Services.AddDbContext<SKNABContext>
              (item => item.UseSqlServer
              (builder.Configuration.GetConnectionString("DefaultConnectionSKNAB"),
              option => option.CommandTimeout(2000000000)));

builder.Services.AddDbContext<General_Banking_RegistersContext>
              (item => item.UseSqlServer
              (builder.Configuration.GetConnectionString("DefaultConnectionGeneralBankingRegisters"),
              option => option.CommandTimeout(2000000000)));

builder.Services.AddTransient<IUserRole, UserRoleService>();
builder.Services.AddTransient<IgetSummary, getSummeryservices>();
builder.Services.AddTransient<IGetDDACReport, GetDDACReportservice>();
builder.Services.AddTransient<IGetLoanCharge, LoanChargeService>();
builder.Services.AddTransient<IStopPayCharge, getStopPayBranchService>();
builder.Services.AddTransient<ITansChargeBranch, TansChargeBranchService>();
builder.Services.AddTransient<ISafekeepingPayments, SafekeepingPaymentservice>();
builder.Services.AddTransient<ICustomerdetail, CustomerDetail>();
builder.Services.AddTransient<IVATOnFraudCharge, getVATOnFraudCharge>();
builder.Services.AddTransient<ITransactionCharges, getTransactionChargesService>();
builder.Services.AddTransient<IUsers, UsersServices>();
builder.Services.AddTransient<IApplication, ApplicationServices>();
builder.Services.AddTransient<IApplicationUserRole, ApplicationUserRoleRepo>();
builder.Services.AddTransient<IUserPermission, UserPermissionService>();
builder.Services.AddScoped<IDormantRegister, DormantRegisterService>();
builder.Services.AddScoped<IFrgnChks, FrgnChksService>();
builder.Services.AddNotyf(config => { config.DurationInSeconds = 5; config.IsDismissable = true; config.Position = NotyfPosition.TopRight; });
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(3600000); });
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromDays(2);
    /*options.IdleTimeout = TimeSpan.FromMinutes(5);*///You can set Time   
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=StandingOrderVat}/{action=TotalSummaryReport}/{id?}");

app.Run();
