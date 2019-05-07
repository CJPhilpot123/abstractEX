using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Television : Machine
    {
        public Television(string i) : base(i)
        {

        } 
        public override void DoStuff()
        {
            throw new NotImplementedException();
        }
        public override void Shutdown()
        {
            throw new NotImplementedException();
        }

        public override void Start(string name)
        {
            throw new NotImplementedException();
        }
    }
}
