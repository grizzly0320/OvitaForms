using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvitaForms
{
    public class Product
    {
        string[] sellPhrases = { "Продаю ", "Продам ", "Хочу продать ", "Срочно продам ", "Не желаете ли ", "Может кому нужна ", "Отдам ", "Отдаю ", "Только сегодня ", "Только сейчас " };
        string[] beforePricePhrases = { " всего за ", " за ", " по цене ", " за сущие " };
        private int id;
        private Bitmap image;
        private string type;
        private string maker;
        private string model;
        private string description;
        private int saler;
        private int category;
        private decimal price;
        private int location;
        private int discontinued;
        public int Id => id;
        public Bitmap Image => image;
        public string Type => type;
        public string Maker => maker;
        public string Model => model;
        public string Description => description;
        public int Saler => saler;
        public int Category => category;
        public decimal Price => price;
        public int Location => location;
        public int Discontinued => discontinued;
        public Product() { }
        public Product(int id, Bitmap image,  string type, string maker, string model, string description, int saler, int category,decimal price, int location, int discontinued)
        {
            this.id = id;
            this.image = image;
            this.type = type;
            this.maker = maker;
            this.model = model;
            this.description = description;
            this.saler = saler;   
            this.category = category;
            this.price = price;
            this.location = location;
            this.discontinued = discontinued;
        }
        public override string ToString()
        {
            Random randSellPhrase = new Random();
            Random randBeforePricePhrase = new Random();
            return sellPhrases[randSellPhrase.Next(sellPhrases.Length)] +  type + " " + maker + " " + model + beforePricePhrases[randBeforePricePhrase.Next(beforePricePhrases.Length)] + price.ToString("#.##");
        }
    }
}
