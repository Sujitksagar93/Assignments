class Employee {
	
	public static void main(String[] args){
	
	int a = Integer.parseInt(args[0]);
	int b = Integer.parseInt(args[1]);
	int c = Integer.parseInt(args[2]);
	double d = Double.parseDouble(args[3]);
	
	Income in = new Income(a,b,c,d);

	in.printIncome();
	System.out.printf("Employee Income is.2%f%n",in.getIncome());
	System.out.printf("Employee Net Income is %.2f%n",in.getNetIncome());
	
	}




}
