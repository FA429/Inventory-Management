
namespace sda_onsite_2_inventory_management.src
{
    public class Item
    {

        private readonly string _name;
        private int _quantity;
        private DateTime _createdAt;

        
           public Item(string name, int quantity, DateTime? createdAt = null)
        {
            _name = name;
            _quantity = (quantity > 0) ? quantity : throw new ArgumentException("Quantity should be bigger than 0");
            this._createdAt = (DateTime)(createdAt is null ? DateTime.Now : createdAt);
        }

        

        public string GetName()
        {
            return _name;
        }

        public int GetQuantity()
        {
            return _quantity;
        }
        public DateTime GetCreatedAt()
        {
            return _createdAt;
        }



    }
}