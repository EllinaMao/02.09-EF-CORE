using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace _02._09_Вступ_EF_CORE
{
    public class Program
    {
        /// <summary>
        /// Code First
        ///1. Магазин – Product
        ///1) + Id: Guid
        ///2) + Name: string
        ///3) + Cost: double
        ///4) + Description: string
        ///5) + Quantity: int
        ///
        ///2. Користувач – User
        ///1) + Id: Guid
        ///2) + Name: string
        ///3) + LastName: string
        ///4) + Login: string
        ///5) + Password: string
        ///6) + Email: string
        ///
        ///3. Замовлення – Order
        ///1) + Id: Guid
        ///2) + Name: string
        ///3) + Create: datetime
        ///4) + Update: datetime
        ///5) + Description: string
        ///
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                   .SetBasePath(AppContext.BaseDirectory)
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                   .Build();

            // Создаем сервисы
            var services = new ServiceCollection();
            services.AddDbContext<ProductsDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            var serviceProvider = services.BuildServiceProvider();

            // Пример: получить контекст и использовать
            using var context = serviceProvider.GetRequiredService<ProductsDbContext>();
            Console.WriteLine($"База данных: {context.Database.GetDbConnection().Database}");
        }
    }
}
