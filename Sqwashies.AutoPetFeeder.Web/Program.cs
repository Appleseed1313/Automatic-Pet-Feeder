using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Sqwashies.AutoPetFeeder.Components;
using Sqwashies.AutoPetFeeder.Web.Data;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

try
{
    var clock = new Clock();
    bool clockIsSet = clock.IsClockSet();

    if (clockIsSet)
    {
        Console.WriteLine("The time is:" + clock.GetClockTime());
        var scheduler = new Scheduler();
        bool schedulerOn = scheduler.IsSchedulerTurnedOn();

        if (schedulerOn)
        {
            Console.WriteLine("Scheduler is On!");

            bool isFeedingTime = scheduler.IsFeedingTime();

            if (isFeedingTime)
            {
                if (scheduler.IsBreakfastTime)
                {
                    Console.WriteLine("Dispense Breakfast");
                    var breakfastDispenser = new Dispenser();
                    breakfastDispenser.DispenseBreakfast();
                }

                if (scheduler.IsDinnerTime)
                {
                    Console.WriteLine("Dispense Dinner");
                    var dinnerDispenser = new Dispenser();
                    dinnerDispenser.DispenseDinner();
                }
            }
        }
        else
        {
            Console.WriteLine("Scheduler not on: Waiting another minute");
        }
    }
    else
    {
        Console.WriteLine("Need to get time from naval clock");
    }
}
catch (Exception ex)
{

    throw;
}

app.Run();
