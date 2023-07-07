class Car: Vehicle{
    private string _type;
    

    public Car(string make, string model, string licenseNum, string year, int millage,int price, string type): base(make, model, licenseNum, year, millage, price){
        _type = type;
        
    }
    override public void Show_vehicle(){
        
    }
}