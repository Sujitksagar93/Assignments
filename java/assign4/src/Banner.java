package BannerPrice;

public class Banner{

	private int height;
	private int width;


//	public Banner(){
//	
//		this(10,12);
//	}

	public Banner(int h, int w){
		
		height = h;
		width = w;
	}
	
	public int getHeight(){
		
		return height;
	}
	public void setHeight(int h){
	
		height = h;
	}

	public int getWidth(){
	
		return width; 
	} 

	public void setWidth(int w){
	
		width = w;
	}
	public double area(){
		
		return height * width ;
	
	}
}
