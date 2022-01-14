using System;
using System.Collections.
Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab5.Models
{
    public class Census
    {
        [Key]
        public long Id { get; set; }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public bool Employed { get; set; }

        public bool Married { get; set; }

    }



}

/*
  private static readonly string[] Nm = new[]
       {
            "John", "Kate", "Adam", "Michael", "Dave"
        };

        private static readonly string[] Sn = new[]
        {
            "Doe", "Johnson", "Dickson", "Kowalsky"
        };


        public IEnumerable<TodoItem> Get()
        {
            var rng = new Random();
            var i = 1;
            return Enumerable.Range(1, 5).Select(index => new TodoItem
            {
                Id = i++,
                Name = Nm[rng.Next(Nm.Length)],
                Surname = Sn[rng.Next(Sn.Length)],
                Employed = rng.NextDouble() >= 0.5,
                Marrie = rng.NextDouble() >= 0.5

            })
            .ToArray();
        }

*/