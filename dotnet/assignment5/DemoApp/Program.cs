using finance;

class program
{
    public static double compute(Loan l){

        return l.EMI();
    }

    public static void Main(string [] args) {

        double principle = double.Parse(args[0]);
        float period = float.Parse(args[1]);

        var a= new Personal(principle , period);
        var b = new Home (principle , period);

        Console.WriteLine("EMI for Personal Loan = {0}" , program.compute(a));    
        Console.WriteLine("EMI for Personal Loan with GST = {0}" , a.GST(program.compute(a)));        
        Console.WriteLine("EMI for Home Loan = {0}" , program.compute(b));        
        Console.WriteLine("EMI for Home Loan with discount = {0}" , b.discountable(program.compute(a)));        
    


    }





}