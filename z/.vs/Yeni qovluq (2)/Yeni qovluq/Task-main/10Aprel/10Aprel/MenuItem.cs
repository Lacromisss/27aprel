using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantOrderSystem
{
    public class MenuItem
    {
        public static int _noSup;
        public static int _noAnaYemek;
        public static int _noIcki;
        public static int _noDesert;
        public MenuItem(Categories category)
        {
            switch (category)
            {
                case Categories.Sup:
                    _noSup++;
                    this.No = (Categories.Sup.ToString().Substring(0, 2)) + _noSup;
                    break;
                case Categories.AnaYemek:
                    _noAnaYemek++;
                    this.No = (Categories.AnaYemek.ToString().Substring(0, 2)) + _noAnaYemek;
                    break;
                case Categories.Icki:
                    _noIcki++;
                    this.No = (Categories.Icki.ToString().Substring(0, 2)) + _noIcki;
                    break;
                case Categories.Desert:
                    _noDesert++;
                    this.No = (Categories.Desert.ToString().Substring(0, 2)) + _noDesert;
                    break;

            }
        }
        public string No { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Categories Category { get; set; }
    }
}
