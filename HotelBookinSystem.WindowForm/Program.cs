using FluentEmail.Core;
using HotelBookinSystem.WindowForm.AppDbContextModels;
using HotelBookinSystem.WindowForm.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookinSystem.WindowForm;

public static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Configure DI container
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddDbContext<AppDbContext>();
        serviceCollection.AddTransient<OtpService>();
        ServiceProvider = serviceCollection.BuildServiceProvider();

        Application.Run(new LoginForm());
    }
}