﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShop
{
    public class StoreInventory
    {
        public List<GameItem> InventoryList { get; set; }
        private enum GameType
        {
            BattleField,
            CyberPunk,
            PokemonLetsGoEevee,
            PUBG,
        }
        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDownLoadable());
            }

        }
        private void Print(List<GameItem> itemsToPrint)
        {
            foreach (var item in itemsToPrint)
            {
                item.PrintGameNameAndPrice();
            }
        }

        public List<GameItem> ListPhysicalItems()
        {
            return InventoryList.Where(GameItem => GameItem is IPhysicalCopy).ToList();
        }
        public List<GameItem> ListDownLoadable()
        {
            return InventoryList.Where(GameItem => GameItem is IDownloadable).ToList();
        }

        public StoreInventory()
        {
            InventoryList = new List<GameItem>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEevee());
            InventoryList.Add(new CyberPunk());
            InventoryList.Add(new BattleField());
        }
    }
}
