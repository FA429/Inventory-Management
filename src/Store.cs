using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace sda_onsite_2_inventory_management.src
{
    public class Store
    {
        private readonly string _name;
        private List<Item> _items;

        public Store(string name)
        {
            _name = name;
            _items = [];
        }

        public bool AddItem(Item newItem)
        {
            Item? foundItem = _items.Find(item => item.GetName() == newItem.GetName());

            // if you found the item has the same name
            if (foundItem != null)
            {
                throw new ArgumentException("Item is found and has the same name");
            }

            _items.Add(newItem);
            return true;
        }

        public List<Item> GetItems()
        {
            return _items;
        }

        public Item? FindByName(Item targetItem)
        {
            return _items.Find(item => item.GetName() == targetItem.GetName());
        }

        

        public bool RemoveItem(Item newItem)
        {

            _items.Remove(newItem);
            return true;
        }

        public List<Item> GetRemove()
        {
            return _items;
        }


        public int GetCurrentVolume()
        {
        
            int totalCurrentVolume = _items.Sum(item => item.GetQuantity()); 
            return totalCurrentVolume;
        }





    }



}
