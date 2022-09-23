using System;
public class sleep
{
    public static void Main(string[] args)
    {
      Inventory inventory = new Inventory(initializeInventory());
    
      double number = ChangeStringtodb(Inputprice());
      string numbers = InputSerail();
      Guitar guitar = new Guitar(number,numbers,"Alder","Stratocaster","Ning");
      Guitar searchGuitar = inventory.Search(guitar);
      if(searchGuitar != null)
      {
        Printinfo(searchGuitar);
      }
      else 
      {
        Console.WriteLine("Try again");
    }
      
    }
    public static Guitar[] initializeInventory()
    {
        Guitar[] guitar = {new Guitar(5000.52,"000001","Alder","Stratocaster","Nhong"),
         new Guitar(7412.52,"000002","Alder","Stratocaster","Jame"),
         new Guitar(3917.52,"000003","Alder","Stratocaster","Jo"),
         new Guitar(8245.52,"000004","Alder","Stratocaster","Ning"),
         new Guitar(1234.52,"000005","Alder","Stratocaster","NUt")};
         return guitar;
    }
    public static void Printinfo(Guitar guitar)
    {
        Console.WriteLine("********************************************");
         Console.WriteLine("Guitar Serial Number: {0}",guitar.GetSerialNumber());
         Console.WriteLine("Guitar Price: {0}",guitar.GetPrice());
         Console.WriteLine("Guitar Builder: {0}", guitar.Get_build());
         Console.WriteLine("Guitar Model: {0}",guitar.Getmodel());
         Console.WriteLine("Guitar wood: {0}",guitar.GetWood());
        Console.WriteLine("********************************************");
         

    }
    public static string InputSerail()
    {
        Console.Write("Pls input your Serial number: ");
        return Console.ReadLine();
    }
    public static string Inputprice()
    {
        Console.Write("Pls input your price: ");
        return Console.ReadLine();
    }
    public static double ChangeStringtodb(string value)
    {
        double.TryParse(value, out double ans);
        return ans;
    }
    
}
