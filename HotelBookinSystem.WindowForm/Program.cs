using HotelBookinSystem.WindowForm.AppDbContextModels;
using Microsoft.Extensions.DependencyInjection;

namespace HotelBookinSystem.WindowForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .BuildServiceProvider();
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm(context));
        }
    }
}