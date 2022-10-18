package hospital;
public class Patient{
	
	protected int patientId;
//	private String patientName;
	protected int bedType;
	protected int noOfDays;
	
	public Patient(int id ,int bedT, int days ){
	
		patientId=id;
	//	String patientName = name;
		bedType = bedT;
		noOfDays= days;
		
	}

	public  Patient(){
	 
		 this(101, 1 , 10); 	
	}

	public int getPatientId(){
		return patientId;
	}
	public void setPatientId(int id){
		patientId= id;
	}

//	public String getPatientName(){
//		return patientName;
//	}
//
//	public void setPatientName(String name){
//		patientName= name;
//	}
	public int getBedType(){
		return bedType;
	}
	public void setBedType(int bedT){
		bedType= bedT;
	}

	public int getNoOfDays(){
		return noOfDays;
	}
	public void setNoOfDays(int days){
		noOfDays= days;
	}

	public double getBillAmount(){
		
		int price=0;

		if (bedType == 1 )
			price = 500;

		if (bedType == 2)
			price = 350;

		if (bedType == 3)
			price = 200;
	
		return noOfDays * price ;
	}

}
