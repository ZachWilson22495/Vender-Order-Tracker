using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Category
  {
    private static List<Category> _instances = new List<Category> {};
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Category(string categoryName)
    {
      Name = categoryName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
  }
}