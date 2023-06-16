using Blazored.SessionStorage;
using web.Services.Http.Auth;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddBlazoredSessionStorage();

builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient<IAuthClient, AuthClient>();

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