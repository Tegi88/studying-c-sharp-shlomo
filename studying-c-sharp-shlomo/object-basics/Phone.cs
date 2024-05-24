using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shlomo.object_basics
{
    public class Phone
    {
        public string Brand;
        public int price;
        public double Wigth;
        public bool Tach;

        public Phone() { }
        public Phone(string brand, int price, double wigth, bool tach)
        {
            this.Brand = brand;
            this.price = price;
            this.Wigth = wigth;
            this.Tach = tach;
        }
    }

    public class Shop
    {
        public string Name;
        public Phone [] phons=new Phone[2];

        public Shop() { }

        public Shop(string name, Phone[] phons)
        {
            this.Name = name;
            this.phons = phons;
        }
    }

    public class CreateNewShop
    {
        public static Phone[] CreatePhon()
        {
            Phone p1 = new Phone("Samsung Galaxy 9", 1540, 9.5, true);
            Phone p2 = new Phone("iphon 15 pro", 5500, 12.6, false);
            Phone [] arry = new Phone[2];
            arry[0] = p1;
            arry[1] = p2;
            return arry;
        }


        public static void CreateShop()
        {
            Shop s1 = new Shop("Fix Phone", CreatePhon());
            Shop s2 = new Shop("Fix Phone", CreatePhon());
        }

    }
    
}
