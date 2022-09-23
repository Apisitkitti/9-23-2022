public class Inventory
{
    Guitar[] guitar;
    public Inventory(Guitar[] guitars)
    {
        this.guitar = guitars;
    }
    public Guitar GetGuitar(string serial_number)
    {
        foreach(Guitar guitar in guitar)
        {
            if(guitar.GetSerialNumber().Equals(serial_number))
            {
                return guitar;
            }
        }
        return null;
    }
    public Guitar GetGuitar(double price)
    {
        foreach(Guitar guitar in guitar)
        {
            if(guitar.GetPrice().Equals(price))
            {
                return guitar;
            }
        }
        return null;
    }
    public Guitar Search(Guitar search)
    {
        foreach(Guitar guitar in guitar)
        {
            string serial_number = search.GetSerialNumber();
            double price = search.GetPrice();

            if(guitar.GetSerialNumber().Equals(serial_number)&& guitar.GetPrice().Equals(price))
            {
                return guitar;
            }
            
        }
        return null;
    }

    

}