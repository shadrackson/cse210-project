// My VS Code is not working as intended
// I am using the github space for my code

// Class
public class Address
{
  private string _street;
  private string _city;
  private string _stateProvince;
  private string _country;


  // Constructor
  public Address(string street, string city, string stateProvince, string country)
  {
    _street = street;
    _city = city;
    _stateProvince = stateProvince;
    _country = country;
  }
  
  // Methods
  public bool IsInUSA()
  {
    return _country.ToUpper() == "USA";
  }
  
  public string GetFullAddress()
  {
    return $"{_street}\n{_city}, {_stateProvince}\n{_country};
  }   
}  

