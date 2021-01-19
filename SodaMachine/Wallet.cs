using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables (Has A)
        public List<Coin> Coins;
        //Constructor (Spawner)
        public Wallet()
        {
            Coins = new List<Coin>();
            FillRegister();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money
        private void FillRegister()
        {
            for (int i = 0; i < 8; i++)
            {
                Coins.Add(new Quarter());
            }
            for (int i = 0; i < 20; i++)
            {
                Coins.Add(new Dime());
            }
            for (int i = 0; i < 18; i++)
            {
                Coins.Add(new Nickel());
            }
            for (int i = 0; i < 10; i++)
            {
                Coins.Add(new Penny());
            }
        }
    }
}
