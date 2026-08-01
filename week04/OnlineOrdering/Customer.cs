// My VS Code is unresponsive
// I have opted for github spaces instead

// Class
public class customer
{
  private string _name;
  private Address _address;
  
  // Constructor
  public Customer(string name, Address address)
  {
    _name = name;
    _address = address;
  }

  public bool LivesInUSA()
  {
    return _address.IsInUSA();
  }

  public string GetName()
  {
    return _name;
  }

  public Address GetAddress()
  {
    return _address;
  }
}  
  
  
