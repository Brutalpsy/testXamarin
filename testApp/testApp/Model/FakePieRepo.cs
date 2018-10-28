using System;
using System.Collections.Generic;
using System.Text;

namespace testApp.Model
{
    public class FakePieRepo
    {
        public Pie GetSingle()
        {
            return new Pie() { Id = 1, Name = "prva", Price = 11.11M };
        }

        public IEnumerable<Pie> GetAll()
        {
            return new List<Pie>()
            {
                new Pie() { Id = 1, Name = "prva", Price = 11.11M },
                new Pie() { Id = 2, Name = "druga", Price = 22.22M },
                new Pie() { Id = 3, Name = "treca", Price = 33.33M },
            };
        }

    }
}
