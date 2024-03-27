using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace sda_onsite_2_inventory_management.src
{
    public class Store
    {
        private readonly string _name;
        private readonly int _max_capacity;
        private List<Item> _items;

        public Store(string name , int max_capacity)
        {
            _name = name;
            _items = [];
            _max_capacity = max_capacity;
        }

        public bool AddItem(Item newItem)
        {
            Item? foundItem = _items.Find(item => item.GetName() == newItem.GetName());

             int availableSpace = GetMaxCapacity() - GetCurrentVolume();
Console.WriteLine($" availableSpace :{availableSpace}");
             if (availableSpace < newItem.GetQuantity())
             {
                throw new Exception("No spaca available");

             }



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
        public List<Item> SortByNameAsc()
        {
            var Item = _items.OrderBy(item => item.GetName()).ToList();
            return Item;
            
        }

        public Item? FindByName(Item targetItem)
        {
            return _items.Find(item => item.GetName() == targetItem.GetName());
        }
 public int GetMaxCapacity(){
    return _max_capacity;
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
