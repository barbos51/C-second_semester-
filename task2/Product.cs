using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Product
    {
        private string _name;
        private int _quantity;
        private float _price;
        public int Quantity => _quantity;
        //public float Price => _price;
        //public string Name => _name;



        public Product(string name, float price, int quantity)
        {
            _name = name;
            _quantity = quantity;
            _price = price;
        }

        public string Name
        {
            get
            {
                return _name; 
                
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Введіть назву товару");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public float Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ціна не може бути від'ємною!");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public void Restock(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Помилка: Додаюча кількість повинна бути невід'ємною!");
                return;
            }
            _quantity += amount;

        }
        public void Sell(int amount)
        {
            if (Quantity < amount)
            {
                Console.WriteLine("Помилка: кількість товару на продаж повинна бути менша за кількість товару на складі");
                return;
            }
            _quantity -= amount;
        }

     

        public float TotalValue()
        {
            return Quantity * _price;
        }

        public string GetInfo()
        {
            return $"Товар: {Name}, Ціна: {Price}, Кількість: {Quantity}, Загальна вартість: {TotalValue()} ";
        }

    }
}
