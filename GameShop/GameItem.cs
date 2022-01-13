﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop
{
    public class GameItem
    {
        public int Price { get; set; }
        public string GameName { get; set; }
        public string Id { get; set; }

        public void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {GameName} Price: {Price} ID: {Id}");
        }
    }
}
