using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualVendingMachine
{
    internal class VendingMachine
    {
        public VendingMachine() { }

        public VendingMachine(List<Soda> sodas) 
        {
            StockMachine(sodas);
        }

        private List<Soda> options;

        public static readonly string OUT_OF_STOCK = "outOfStock";

        public void StockMachine(List<Soda> sodas) 
        {
            options = sodas;
        }

        public List<Soda> GetSodaOptions()
        {
            return options;
        }

        public string? BuySoda(string name)
        {//return can image uri
            Soda sodaBrandBought = FindSoda(name);

            if (sodaBrandBought.amount == 0)
            {
                return OUT_OF_STOCK;
            }

            sodaBrandBought.amount--;

            return sodaBrandBought.canImage;
        }
        public Soda FindSoda(string name)
        {
            Soda? sodaBox = options.SingleOrDefault(s => s.name == name);
            if (sodaBox == null)
            {
                throw new Exception($"Soda Brand ${name} Does Not Exist In The Vending Machine");
            }
            return sodaBox;
        }
        private void ValidateStock(List<Soda> sodas)
        {
            foreach (Soda soda in sodas)
            {
                if(ValidateSoda(soda) == false)
                {
                    throw new Exception($"Invalid Soda: ${soda.name}");
                }
            }

        }
        private bool ValidateSoda(Soda soda)
        {
            if(soda.amount < 0)
            {
                return false;
            }
            if(soda.name == "" || soda.name is null)
            {
                return false;
            }
            if (soda.canImage == "" || soda.canImage is null)
            {
                return false;
            }
            if (soda.vendingLabelImage == "" || soda.vendingLabelImage is null)
            {
                return false;
            }
            if (soda.price < 0)
            {
                return false;
            }

            return true;
        }
        private void Restock(Soda newSodaBox)
        {
           Soda oldSodaBox = FindSoda(newSodaBox.name);

            oldSodaBox.amount += newSodaBox.amount;
            oldSodaBox.price = newSodaBox.price;
            oldSodaBox.canImage = newSodaBox.canImage;
            oldSodaBox.vendingLabelImage = newSodaBox.vendingLabelImage;
        }
    }
}
