using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    abstract class Machine
    {
        private string id;

        public string ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public Machine(string i)
        {
            id = i;
        }

        public abstract void Start(string name);
        public abstract void DoStuff();
        public abstract void Shutdown();

        public void run(string name)
        {
            Start(name);
            DoStuff();
            Shutdown();
        }

        public override string ToString()
        {
            return "Machine id" + id;
        }
    }
}
