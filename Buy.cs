using System;
using System.Collections.Generic;
using System.Text;

namespace SIGMA_2
{
    class Buy
    {
        private Product prodToBuy;
        private int amount;
        private double sum;
        private double weight;

        public Buy(Product product, int numberOfProducts, double sumOfProducts, double weightOfProducts)
        {
            amount = numberOfProducts;
            prodToBuy = product;
            sum = sumOfProducts;
            weight = weightOfProducts;
        }

        public Buy() { }

        public Product ProdToBuy
        {
            get
            {
                return prodToBuy;
            }
            set
            {
                prodToBuy = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public double Sum
        {
            get
            {
                return sum;
            }
            set
            {
                sum = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public double CalculateSum(Product obj1, int number)
        {
            return obj1.Price * number;
        }

        public double CalculateWeight(Product obj1, int number)
        {
            return obj1.Weight * number;
        }
    };
}
