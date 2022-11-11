class Employee{

    private int Eid;
    private int age;
    private int hours;
    private Double rate;

    public  Employee(int id , int a , int h , double r)
    {

        Eid = id;
        age = a;
        hours = h;
        rate = r; 

    } 
    public  Employee()
    {

        Eid = 101;
        age = 21;
        hours = 12;
        rate = 0; 

    } 
public double GetNetIncome(int hours, double rate){

    return hours * rate;


}

}