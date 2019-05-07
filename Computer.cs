using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Computer : Machine
    {
        private bool keyboard;

        public bool Keyboard
        {
            set { keyboard = value; }
            get { return keyboard; }
        }

        public Computer(string i, string k) : base(i)
        {

        }

        public override void Start(string name)
        {
            Console.WriteLine("The computer is starting!");
        }

        public override void DoStuff()
        {
            Console.WriteLine("The Computer is doing the things!");
        }

        public override void Shutdown()
        {
            Console.WriteLine("aaaaaaand we're shutting down,");
        }

        public override string ToString()
        {
            return base.ToString() + $"Keyboard: {keyboard}";
        }

    }
}
