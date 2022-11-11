namespace medical;
public class InHousePatient : Patient{

    private double discount;

    public InHousePatient(int id ,string name, int bedT , int d , double dis ): base(id ,name ,bedT ,d )
    {
        discount = dis;
    } 

    public double GetDiscount()
    {
        return discount;
    }

    public override double getBillAmount()
    {
       double i =base.getBillAmount();
       if(i>=5000)
       return i- (i * discount );
       return i;
    }
}