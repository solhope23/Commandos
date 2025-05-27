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
            Commando newCommando = new Commando("david", "007");
            Weapon newWeapon = new Weapon("gun", "baba", 5);
        }
    }
}
