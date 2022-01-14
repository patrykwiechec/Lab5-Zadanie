using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Lab5.Models
{
    public class DataGenerator
    {
        private static readonly string[] Nm = new[]
         {
            "John", "Kate", "Adam", "Michael", "Dave"
        };

        private static readonly string[] Sn = new[]
        {
            "Doe", "Johnson", "Dickson", "Kowalsky"
        };

        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new TodoContext(
             serviceProvider.GetRequiredService<DbContextOptions<TodoContext>>()))
            {
                if (context.TodoItems.Any())
                {
                    return;
                }

                var rng = new Random();
                var i = 1;

                context.TodoItems.AddRange(
                    new Census
                    {
                        Id = i++,
                        Name = Nm[rng.Next(Nm.Length)],
                        Surname = Sn[rng.Next(Sn.Length)],
                        Employed = rng.NextDouble() >= 0.5,
                        Married = rng.NextDouble() >= 0.5
                    },
                    new Census
                    {
                        Id = i++,
                        Name = Nm[rng.Next(Nm.Length)],
                        Surname = Sn[rng.Next(Sn.Length)],
                        Employed = rng.NextDouble() >= 0.5,
                        Married = rng.NextDouble() >= 0.5
                    },
                    new Census
                    {
                        Id = i++,
                        Name = Nm[rng.Next(Nm.Length)],
                        Surname = Sn[rng.Next(Sn.Length)],
                        Employed = rng.NextDouble() >= 0.5,
                        Married = rng.NextDouble() >= 0.5
                    },
                    new Census
                    {
                        Id = i++,
                        Name = Nm[rng.Next(Nm.Length)],
                        Surname = Sn[rng.Next(Sn.Length)],
                        Employed = rng.NextDouble() >= 0.5,
                        Married = rng.NextDouble() >= 0.5
                    },
                    new Census
                    {
                        Id = i++,
                        Name = Nm[rng.Next(Nm.Length)],
                        Surname = Sn[rng.Next(Sn.Length)],
                        Employed = rng.NextDouble() >= 0.5,
                        Married = rng.NextDouble() >= 0.5
                    });

                context.SaveChanges();
            }
        }
    }
} 
