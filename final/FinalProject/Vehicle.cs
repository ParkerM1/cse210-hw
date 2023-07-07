class Vehicle{
    private string _make;
    private string _model;
    private string  _licenseNum;
    private string _year;
    private int _millage;
    private int _price;

    public Vehicle(string make, string model, string licenseNum, string year, int millage, int price){
        _make = make;
        _model = model;
        _licenseNum = licenseNum;
        _year = year;
        _millage = millage;
        _price = price;
    }

    virtual public void Show_vehicle(){

    }
}