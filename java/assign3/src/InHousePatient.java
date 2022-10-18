package hospital;

public class InHousePatient extends Patient{

	private double discount;

	public InHousePatient(int id ,  int bedT, int d, double dis){
	
		super(id,bedT,d);
	       
		discount = dis;
	
	}
	
	public double getDiscount(){
		return discount;
	}

//	public void setDiscount(double dis){
//		discount = dis;
//	}
/*
	public double getBillAmount(){
	
		double price=0;

		if (super.getBedType() == 1)
			price =500;

		if (super.getBedType() == 2)
			price=350;

		if (super.getBedType() == 3)
			price = 200;

		return super.getNoOfDays() * price;
	}
*/

                public double getBillAmount(){
			 
		 	double i = super.getBillAmount();
			if(i>=5000)
				return i - (i * discount);
			return i;
	

		
	} 
}
