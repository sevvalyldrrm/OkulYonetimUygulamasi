﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi
{
    internal class Adres
    {
        public string Il;
        public string Ilce;
        public string Mahalle;
        public Adres(string il, string ilce, string mahalle)
        {
            this.Il = il;
            this.Ilce = ilce;
            this.Mahalle = mahalle;
        }

    }

}
