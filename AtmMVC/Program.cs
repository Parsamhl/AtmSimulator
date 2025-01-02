using App.Domain.AppService.Atm.Card;
using App.Domain.AppService.Atm.Transaction;
using App.Domain.AppService.Atm.User;
using App.Domain.Core.Atm.Card.AppService;
using App.Domain.Core.Atm.Card.Data.Repository;
using App.Domain.Core.Atm.Card.Service;
using App.Domain.Core.Atm.Transaction.AppService;
using App.Domain.Core.Atm.Transaction.Data.Repository;
using App.Domain.Core.Atm.Transaction.Service;
using App.Domain.Core.Atm.User.AppService;
using App.Domain.Core.Atm.User.Data.Repository.cs;
using App.Domain.Core.Atm.User.Service;
using App.Domain.Service.Atm.Card;
using App.Domain.Service.Atm.Transaction;
using App.Domain.Service.Atm.User;
using App.infra.DataRepo.Ef.Atm.Card;
using App.infra.DataRepo.Ef.Atm.Transaction;
using App.infra.DataRepo.Ef.Atm.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<ICardService, CardService>();
builder.Services.AddScoped<ICardAppService, CardAppService>();

builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionService, TransactionService>();
builder.Services.AddScoped<ITransactionAppService , TransactionAppService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserAppService, UserAppService>();




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
