using Blazored.SessionStorage;
using web.Services.Http.Auth;
using web.Services.Session;
using ISession = web.Services.Session.ISession;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient<IAuthClient, AuthClient>();
builder.Services.AddScoped<ISession, Session>();


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