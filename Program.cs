using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using ConcertTicketing.Data;
using ConcertTicketing.Services;
using concert_ticketing.Forms;
using concert_ticketing;

namespace ConcertTicketing
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // ?? Setup dependency injection container
            var services = new ServiceCollection();

            // ? Register DbContext
            services.AddDbContext<ConcertTicketContext>();

            // ? Register services
            services.AddScoped<AccountService>();
            services.AddScoped<ConcertService>(); // ?? Tambahkan ini

            // ? Register forms
            services.AddScoped<Form1>();
            services.AddScoped<FormAccount>();
            services.AddScoped<FormTicket>();
            services.AddScoped<FormConcerts>();

            // ?? Build service provider
            var serviceProvider = services.BuildServiceProvider();

            // ?? Jalankan Form1 dengan DI
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}
