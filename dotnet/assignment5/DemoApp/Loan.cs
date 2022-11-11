namespace finance;
public abstract class  Loan
{

public double principle{ get; set; }

public float period{get; set;}

public abstract float GetRate();

public double EMI(){

	double EMI = principle * (1 + GetRate() * period / 100) / (12*period);
	return EMI;
}




}


