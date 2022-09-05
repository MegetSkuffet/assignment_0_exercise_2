namespace exercise0;



public class LeapYear{

    public static void Main(String[] args)
    {
        Console.WriteLine("write a year to find out if it is a leapyear!");
        var year = new LeapYear();
        year.IsLeapYear(Convert.ToInt32(Console.ReadLine()));
    }
    public string IsLeapYear(int year)
    {
        if(year%4==0) {
            Console.WriteLine("yay") ;
            return "yay";
        }
        else {
            Console.WriteLine("nay");
            return "nay";
        }
        
    }
}
