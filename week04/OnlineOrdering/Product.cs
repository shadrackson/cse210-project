// VS Code is misbehaving

// Class
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

 // Constructors
 public product(string name, string productId, double price, int quantity)
   {
     _name = name;
     _productId = productId;
     _price = price;
     _quantity = quantity;
   }

  // Getting total cost
 public double GetTotalCost()
 {
   return _price * _quantity;
 }

 // Getters

  public string GetName()
  {
    return _name;
  }

  public string GetProductId()
  {
    return _productId;
  }  
  
