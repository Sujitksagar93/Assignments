class Income{

	private int Eid;
	private int Age;
	private int hours;
	private double rate;

	public Income(int id, int a,int h,double r){
	
		Eid=id;
		Age=a;
		hours=h;
		rate=r;
	
	}
	public void printIncome(){
	
	System.out.printf("Employee Id is =%d%n",Eid);
	System.out.printf("Employee age is =%d%n",Age);
	System.out.printf("Employee hours is =%d%n",hours);
	System.out.printf("Employee rate is =%f%n",rate);
	
	}

	public double getIncome(){
	
		return hours * rate;
	
	}
	public double getNetIncome(){
	
		if (hours>180)
		{
			return getIncome() + (( hours-180)*100);
		}
		else 
			return getIncome();
	
	}
}
