using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpelForelasning
{
    public class MainViewModel
    {
        // viktigt
        // Det måste vara properties

        public string FirstName { get; set; } = "Robin";

        public MainViewModel()
        {
            Player player = new Human();
            player.Name = FirstName;
        }
    }
}
