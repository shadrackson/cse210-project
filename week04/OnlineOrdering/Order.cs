// Same 

using System.Collections.Generic;

// Creating the class
public class Order
{
    private List<Product> _products;
    private Customer _customer;

// Constructor
    public Order(Customer customer, List<Product> products)
    {
      _customer = customer;
      _products = products;
    }

 // Methods
     public double GetTotalPrice()
     {
       double total = 0;

       foreach (Product product in _products)
       {
         total += product.GetTotalCost();
       }

       if (_customer.LivesInUSA())
       {
         total += 5;
       }

       else
       {
         total += 35;
       }

       return total;
     }
     public string GetPackingLabel()
      {
          string label = "";
  
          foreach (Product product in _products)
          {
              label += $"Product: {product.GetName()}\n";
              label += $"ID: {product.GetProductId()}\n\n";
          }
  
          return label;
      }
  
      public string GetShippingLabel()
      {
          return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
      }
}
    
    
  
