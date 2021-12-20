using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor 
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Collection { get; set; }
    public int Id { get; }

    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string description, string collection)
    {
      Name = name;
      Description = description;      
      Collection = collection;     
      
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}