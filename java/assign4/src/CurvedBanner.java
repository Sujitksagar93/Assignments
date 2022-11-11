package BannerPrice;

public class CurvedBanner extends Banner{

		private float radius;

//	public CurvedBanner(){
		
//		super();

//		radius = 0.5f;
//	}

	public CurvedBanner(int h , int w , float r){
	
		super(h,w);

		radius = r;
	}

	public float getRadius(){
	
		return radius;
	}

	public void setRadius(float r){
	
		radius = r;
	}

	public double area(){
		
		return super.area()- 0.86 * radius * radius;
	}
}
