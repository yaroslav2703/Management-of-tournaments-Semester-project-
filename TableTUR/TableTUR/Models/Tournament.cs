using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Main
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Count { get; set; }
        public int Count_completed { get; set; }
        public bool isGenerate { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Game> Games { get; set; }

        public Tournament()
        {
            Teams = new List<Team>();
            Games= new List<Game>();
        }

        public override string ToString()
        {
            return Title;
        }






    }
}
