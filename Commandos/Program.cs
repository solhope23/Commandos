using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Commando[] CommandoList = new Commando[3] { new Commando("Moshe", "006"), new SeaCommando("david", "007"), new AirCommando("ddaa", "008") };
            foreach (Commando soldier in CommandoList)
            {
                soldier.Attack();
            }

        }

    }
}
