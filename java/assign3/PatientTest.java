import hospital.Patient;
import hospital.InHousePatient;
class PatientTest{

	public static void main(String[] args){
	
		int patientId = Integer.parseInt(args[0]);
		int bedType = Integer.parseInt(args[1]);
		int noOfDays = Integer.parseInt(args[2]);



	Patient p = new Patient(patientId, bedType ,noOfDays);
	InHousePatient ip = new InHousePatient(patientId, bedType, noOfDays,0.05);
	
	//p.setPatientId(101);
	//p.setBedType(1);
	//p.setNoOfDays(10);	

	System.out.printf(" patinet id %d %n",patientId);
	System.out.printf(" bedtype  %d %n",bedType);
	System.out.printf(" no od days  %d %n",noOfDays);
	System.out.printf("Regular Patient details %.2f %n",p.getBillAmount());
	System.out.printf("Regular InHousePatient details %.2f %n",ip.getBillAmount());
	




	}



}
