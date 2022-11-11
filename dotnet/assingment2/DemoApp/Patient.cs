namespace medical;
public class Patient
{
 private int patientId;
 public string patientName;

 private int bedType;
 private int noOfDays;

	public  Patient(int id , string name , int bedT , int days)
    {

        patientId=id;
        patientName = name;
		bedType = bedT;
		noOfDays= days;
		
    }

    public Patient()
    {
      patientId=1;
		patientName= "Ballu";
		bedType = 1;
		noOfDays= 10;
    }
    

    public int PatientId{
        get {return patientId;}
        set {patientId = value;}
    }

    public String PatientName{
        get {return patientName;}
        set {patientName = value;}
    }

    public int BedType{
        get {return bedType;}
        set {bedType = value;}
    }

    public int NoOfDays{
        get { return noOfDays;}
        set {noOfDays = value;}
    }

    public virtual double getBillAmount(){

        int price = 0;
        if (bedType == 1 )
			price = 500;

		if (bedType == 2)
			price = 350;

		if (bedType == 3)
			price = 200;
	
		return noOfDays * price ;

    }
}