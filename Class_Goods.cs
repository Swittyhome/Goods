﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication80
{
     class Goods
    {
        int ID_goods { get; set; }
        string name;
        int category;
        string production_date;
        string expiration_date;
        int price_per_unit { get; set; }
        string brief_description;
        string notes;

          }

    class Program
    {
        static void Main(string[] args)
        {
            Goods goods = new Goods();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
