using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Main
{
   public class Game
    {
        public int Id { get; set; }
        public Tournament Name { get; set; }
        public Team First{ get; set; }
        public Team Second { get; set; }
        public Team Winner { get; set; }
        public bool Was { get; set; }

    }
}
