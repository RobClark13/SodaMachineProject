using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //Member Variables (Has A)
        public Wallet Wallet;
        public Backpack Backpack;

        //Constructor (Spawner)
        public Customer()
        {
            Wallet = new Wallet();
            Backpack = new Backpack();
        }
        //Member Methods (Can Do)

        //This method will be the main logic for a customer to retrieve coins form their wallet.
        //Takes in the selected can for price reference
        //Will need to get user input for coins they would like to add.
        //When all is said and done this method will return a list of coin objects that the customer will use a payment for their soda.
        public List<Coin> GatherCoinsFromWallet(Can selectedCan)
        {
            List<Coin> gatherCoins = new List<Coin>();
            double gatherCoinsValue = 0;
            string chosenCoin;
            while(gatherCoinsValue < selectedCan.Price)
            {
                chosenCoin = UserInterface.CoinSelection(selectedCan, gatherCoins);
                if (chosenCoin == "Quarter")
                {
                    Coin quarter = GetCoinFromWallet("Quarter");
                    gatherCoins.Add(quarter);
                    gatherCoinsValue += quarter.Value;
                }
                else if (chosenCoin == "Dime")
                {
                    Coin dime = GetCoinFromWallet("Dime");
                    gatherCoins.Add(dime);
                    gatherCoinsValue += dime.Value;
                }
                else if (chosenCoin == "Nickel")
                {
                    Coin nickel = GetCoinFromWallet("Nickel");
                    gatherCoins.Add(nickel);
                    gatherCoinsValue += nickel.Value;
                }
                else if (chosenCoin == "Penny")
                {
                    Coin penny = GetCoinFromWallet("Penny");
                    gatherCoins.Add(penny);
                    gatherCoinsValue += penny.Value;
                }
                else
                {
                    break;
                }
            }
            return gatherCoins;
        }
        //Returns a coin object from the wallet based on the name passed into it.
        //Returns null if no coin can be found
        public Coin GetCoinFromWallet(string coinName)
        {
            foreach (Coin coin in Wallet.Coins)
            {
                if (coin.Name == coinName)
                {
                    Wallet.Coins.Remove(coin);
                    return coin;
                }
            }
            return null;
        }
        //Takes in a list of coin objects to add into the customers wallet.
        public void AddCoinsIntoWallet(List<Coin> coinsToAdd)
        {
            foreach(Coin coin in coinsToAdd)
            {
                Wallet.Coins.Add(coin);
            }
        }
        //Takes in a can object to add to the customers backpack.
        public void AddCanToBackpack(Can purchasedCan)
        {
            Backpack.cans.Add(purchasedCan);  
        }
    }
}
