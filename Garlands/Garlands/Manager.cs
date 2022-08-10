using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garlands
{
    class Manager
    {
        private static Random rnd = new Random();
        private List<Manager> garlands;
        
        private char view;
        private int width, height;
        private int x, y;
      
        
        public Manager()
        {
            garlands = new List<Manager>();
            width = Console.WindowWidth - 2;
            height = Console.WindowHeight - 2;
        }
        
        public Manager(int x=0, int y=0,char view='*')
        {
            this.x = x;
            this.y = y;
            this.view = view;
        }

        public Manager(Manager manager)
        {
            this.x = manager.x;
            this.y = manager.y;
            this.view = manager.view;
        }
        public void AddGaralands(int count)
        {
            for (int i = 0; i < count; i++)
            {
                garlands.Add(CreateNewGaraland());
            }
        }
       
        public void AddSingleGaraland(Manager manager)
        {
            garlands.Add(manager);
        }
        public void StartSimulation()
        {
            Console.Clear();
            ShowAll();


            for (int i = 0; i < garlands.Count; i++)
            {
                while (i != garlands.Count)
                {
                    garlands[i].Show();
                    Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                    //Console.ForegroundColor = ConsoleColor.Green;
                    System.Threading.Thread.Sleep(100);
                    i++;
                }
            }
        }
        private void ShowAll()
        {
            for (int i = 0; i < garlands.Count; i++)
            {
                garlands[i].Show();
            }
        } 
        private Manager CreateNewGaraland()
        {
            int x = rnd.Next(0, width);
            int y = rnd.Next(0,height);
            char view = '*';
            Manager manager = new Manager(x, y, view);
            return manager;
        }
        private void Show()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(view);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
