using Microsoft.Extensions.DependencyInjection;
using TaskManagementSystem.Forms;
using TaskManagementSystem.Models;
using TaskManagementSystem.Repository;
using TaskManagementSystem.Services;

namespace TaskManagementSystem
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build the provider and set it globally
            ServiceProvider = serviceCollection.BuildServiceProvider();

            // Run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Register your services here
            services.AddDbContext<AppDBContext>();

            services.AddTransient<TasksService>();
            services.AddTransient<CategoryService>();
            services.AddTransient<UserService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // Register your forms
            services.AddTransient<Form1>(); // Register the main form
            services.AddTransient<TaskVW>();
            services.AddTransient<TaskFieldsForm>(); 
            services.AddTransient<Register>();
            services.AddTransient<Login>();
            services.AddTransient<MainForm>();
            services.AddSingleton<NavigationService>();


        }
    }
}