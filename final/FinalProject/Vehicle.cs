class Vehicle{
    private string _make;
    private string _model;
    private string  _licenseNum;
    private string _year;
    private int _millage;
    private int _price;
    private string _available;

    public Vehicle(){
        
    }

    public Vehicle(string make, string model, string licenseNum, string year, int millage, int price, string available){
        _make = make;
        _model = model;
        _licenseNum = licenseNum;
        _year = year;
        _millage = millage;
        _price = price;
        _available = available;
    }

    public string GetMake (){
        return _make;
    }

    public string GetModel (){
        return _model;
    }
    
    public string GetLicenseNum (){
        return _licenseNum;
    }

    public string GetYear (){
        return _year;
    }

    public int GetMillage (){
        return _millage;
    }

    public int GetPrice (){
        return _price;
    }

    public string GetAvailable (){
        return _available;
    }

    virtual public void ShowVehicle(){

    }
}