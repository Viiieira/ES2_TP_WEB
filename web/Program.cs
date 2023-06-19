using Blazored.SessionStorage;
using web.Pages;
using web.Services.Http;
using web.Services.Http.Auth;
using web.Services.Session;
using ISession = web.Services.Session.ISession;
using ProfessionalArea = web.Services.Http.ProfessionalArea.ProfessionalArea;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddServerSideBlazor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient<IAuthClient, AuthClient>();
builder.Services.AddScoped<ISession, Session>();
builder.Services.AddScoped<IProfessionalArea, ProfessionalArea>();
builder.Services.AddScoped<EditProfessionalArea>();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.Use((context, next) =>
    {
        context.Request.Scheme = "https";
        return next();
    });

    app.UseHttpsRedirection();
}

app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();