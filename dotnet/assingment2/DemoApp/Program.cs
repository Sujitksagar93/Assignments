using medical;
class Program{
    
    public static void Main(string[] args){

        int id = int.Parse(args[0]);
        string name = (args[1]);
        int bedT = int.Parse(args[2]);
        int days = int.Parse(args[3]);

        Patient p = new Patient(id ,name,bedT ,days );
         InHousePatient Ip = new InHousePatient (id , name , bedT ,days ,0.05 );

        Console.WriteLine(" The patient id  ={0}",id);
        Console.WriteLine(" The patient name  ={0}",name );
        Console.WriteLine(" The patient bedtype  ={0}",bedT );
        Console.WriteLine(" The patient days ={0}",days );

        Console.WriteLine("the Patient bill amount is  {0} ",p.getBillAmount ());  
        Console.WriteLine("the InHousePatient bill amount is  {0} ",Ip.getBillAmount ());  

    }


}