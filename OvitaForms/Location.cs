using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvitaForms
{
    public class Location
    {
        string city;
        string region;
        int postal_code;
        string country;
        //pria

        string City => (CheckLetters(city)) ? city : throw new Exception();
        string Region => (CheckLetters(region)) ? region : throw new Exception("");

        public Location(string city, string region, int postal_code, string country)
        {
            this.city = city;
            this.region = region;
            this.postal_code = postal_code;
            this.country = country;
        }

        // Метод проверки символов в слове, на принадлежность к символам букв
        private bool  CheckLetters(string str)
        {
            str = str.ToUpper();
            for (int i = 0;i <  str.Length; i++)
            {
                if (str[i] < 65 || str[i] > 90) //|| str[i] < 192  || str[i] > 223)
                    return false;

            }
            return true;
        }
    }
}
