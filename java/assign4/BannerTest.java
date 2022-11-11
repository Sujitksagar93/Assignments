
import  BannerPrice.*;
import java.util.Scanner;
class BannerTest{

	public static void main(String[] args){
	
	Scanner sc = new Scanner(System.in);
	
	System.out.println("Enetr height of banner ");
	int height = sc.nextInt();
	System.out.println("Enetr width of banner ");
	int width = sc.nextInt();
	System.out.println("Enetr radius of banner ");
	float radius = sc.nextFloat();

	Banner b = new Banner(height,width);
	CurvedBanner cb = new CurvedBanner(height,width,radius);

	System.out.printf("the area of banner is %f%n ",b.area());
	System.out.printf("the area of Curved banner is%f%n ",cb.area());
	
	
	}


}
