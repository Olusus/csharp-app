using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    public class Tworcy//klasa
    {
        public Tworcy( string email="", string name="", string imagelink="")
        {
            Email = email;
            Name = name;
            ImageLink = imagelink;
            
        } //konstruktor
        public string Email { get; set; } //property 
        public string Name { get; set; }

        public string ImageLink { get; set; }
    }
}
