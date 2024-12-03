
using FluentEmail.Core;
using HotelBookinSystem.WindowForm.AppDbContextModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookinSystem.WindowForm;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection.AddDbContext<AppDbContext>();

       

        var serviceProvider = serviceCollection.BuildServiceProvider();
        var context = serviceProvider.GetRequiredService<AppDbContext>();

        ApplicationConfiguration.Initialize();
        Application.Run(new LoginForm(context));

    }
}
