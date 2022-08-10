using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garlands
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.AddGaralands(50);
            manager.StartSimulation();
            Console.ReadKey();
        }
    }
}
