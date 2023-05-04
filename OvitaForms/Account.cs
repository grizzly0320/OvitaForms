using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvitaForms
{
    public class Account
    {
        private int id;
        private Bitmap image;
        private string lastName;
        private string firstName;
        private string phone;
        private string email;
        private string password;
        public int Id => id;
        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }
        public string LastName { get { return lastName; } set { lastName = value;  } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string Phone { get { return phone; } set { phone = value;  } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        //public Account(int id, string lastName, string firstName, string phone, string email, string password)
        //{
        //    this.id = id;
        //    this.lastName = lastName;
        //    this.firstName = firstName;;
        //    this.phone = phone;
        //    this.email = email;
        //    this.password = password;
        //}
        public Account(int id, Bitmap image,  string lastName, string firstName, string phone, string email, string password)
        {
            this.id = id;
            this.image = image;
            this.lastName = lastName;
            this.firstName = firstName; ;
            this.phone = phone;
            this.email = email;
            this.password = password;
        }
    }
}
