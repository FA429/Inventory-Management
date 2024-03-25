
namespace sda_onsite_2_inventory_management.src
{
    public class Item
    {
        
    private readonly string _name;
    private int _quantity;
    private DateTime _createdAt;

    public  Item(string name, int quantity, DateTime? createdAt=null) {
        this._name = name;
        this._quantity = quantity;
        this._createdAt =DateTime.Now;
            
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



}}