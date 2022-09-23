public class Guitar
{
    string serial_number;
    double price;
    string wood;
    string model;
    string Builder;
    public Guitar(double price , string serial,string wood,string model,string Builder)
    {
        this.serial_number = serial;
        this.price = price;
        this.wood = wood;
        this.model = model;
        this.Builder = Builder;
   
    }
    public string GetSerialNumber()
    {
        return this.serial_number;
    }
    public double GetPrice()
    {
        return this.price;
    }
    public string GetWood()
    {
        return this.wood;
    }
    public string Getmodel()
    {
        return this.model;
    }
    public string Get_build()
    {
        return this.Builder;
    }

    
}
