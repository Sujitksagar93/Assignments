class Program{

    public static void Main(string[] args){

        int id = int.Parse(args[0]);
        int a = int.Parse(args[1]);
        int h = int.Parse(args[2]);
        double r = double.Parse(args[3]);

        Employee emp = new Employee(id,a,h,r);

        Console.WriteLine("the emp id = {0}",id);
        Console.WriteLine("the emp age = {0}",a);
        Console.WriteLine("the emp hourse = {0}",h);
        Console.WriteLine("the emp rate = {0}",r);

        Console.WriteLine("the Employe income = {0}",emp.GetNetIncome(h,r));


    }


}