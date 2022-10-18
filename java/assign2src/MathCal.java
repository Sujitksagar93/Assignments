import math.MathUtil;
import java.util.Scanner;
class MathCal{

	public static void main(String [] args){
	
	int a= Integer.parseInt(args[0]);

//	Scanner s= new Scanner(System.in);
//	int a=s.nextInt();

	if (MathUtil.isEven(a))
	System.out.printf("Method 1 the number is even %d%n",a);


	boolean number=MathUtil.isEven(a);
	if (number==true)
		System.out.println("the number is even" +a);
	else
		System.out.println("the number is odd"  +a);

	boolean number1=MathUtil.isOdd(a);
	if (number1==true)
		System.out.println("the number is even : "+a);
	else
		System.out.println("the number is odd : "+a);

	boolean number2=MathUtil.isPrime(a);
	if (number2==true)
		System.out.println("the number is prime : "+a);
	else
		System.out.println("the number is not prime :"+a);

	int number3=MathUtil.reverse(a);
	
		System.out.printf("the number is  : %d" , MathUtil.reverse(a));


//	System.out.printf("the number is odd =%d%n ",a.isOdd(number));
	
	
	
	
	}




}
