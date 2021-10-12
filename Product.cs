using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace SIGMA_2
{
    class Product
    {
        private string name;    
        private double price;
        private double weight;
        private int expirationDate;
        private string date;
        public Product(string s_name, double dbl_price, double dbl_weight, int n_exp_date, string s_date)
        {
            name = s_name;
            price = dbl_price;
            weight = dbl_weight;
            expirationDate = n_exp_date;
            date = s_date;
        }

        public Product() { }

        public int ExpirationDate
        {
            get
            {
                return expirationDate;
            }
            set
            {
                expirationDate = value;
            }

        }
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
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


        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            Product product = other as Product;

            if (product as Product == null)
            {
                return false;
            }

            return product.Name == this.Name;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + "\nPrice: " + this.Price + "\nWeight: " + this.Weight + "\nDate: " + this.Date + "\nExpiration date: " + this.ExpirationDate;
        }

        public virtual void ChangePrice(double percent)
        {
            double percantage = percent / 100;
            this.Price = this.Price + (this.Price * percantage);
        }

        public void Parse(string values)
        {
            try
            {
                string pattern = @"[A-z]\s[0-9]*[.,]?[0-9]+\s[0-9]*[.,]?[0-9]+\s[0-9]\s\d{2}.\d{2}.\d{4}";
               
                if (Regex.IsMatch(values, pattern, RegexOptions.IgnoreCase))
                {
                    var arr = values.Split(' ');

                    this.Name = arr[0];
                    this.Price = Double.Parse(arr[1]);
                    this.Weight = Double.Parse(arr[2]);
                    this.ExpirationDate = Int32.Parse(arr[3]);
                    this.Date = arr[4];
                }
                else
                {
                    throw new Exception("Bad input");
                }


            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }

          
            }
        }


    };

