using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge1.DL;

namespace challenge1.BL
{
    class product
    {

        public string name;
        public string category;
        public float price;
        public int qunatity;
        public product(string name, string category, float price, int qunatity)

        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.qunatity = qunatity;
        }

        public product(string name, int qunatity)

        {
            this.name = name;
            this.qunatity = qunatity;
        }

        public product()
        {

        }

        public float calculateTax()
        {
            float tax;
            if (this.category == "fruit")
            {
                tax = (this.price / 100f) * 15;
            }
            else if (this.category == "grocery")
            {
                tax = (this.price / 100f) * 10;
            }
            else
            {
                tax = (this.price / 100f) * 5;
            }
            return tax;
        }

        public void decrementInStock(product p)
        {
            this.qunatity = this.qunatity - p.qunatity;
            ProductCrud.updateQuantityInFile(this);
        }

        public float generteInvoice(product p)
        {
            float totalp;
            totalp = (price * p.qunatity) + calculateTax();
            return totalp;
        }
    }
}
