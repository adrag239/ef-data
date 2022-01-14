using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BabelfishPoC
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello Babelfish!");

            using (var dbContext = new NorthwindDbContext())
            {
                var seeder = new SampleDataSeeder(dbContext);

                await seeder.SeedCustomersAsync();

                var customer = await dbContext.Customers.FirstOrDefaultAsync(c => c.CustomerId == "GALED");

                Console.WriteLine(customer.Address);
                Console.ReadLine();
            }
        }
    }

    

}
