namespace bannerPrice;

public class CurvedBanner : Banner{

private float radius {get; set;}

public CurvedBanner(int h , int w , int r) : base( h , w)
{
    radius = r;
    

}

/*public float Radius{
    get { return radius;}
    set { radius = value;}
}
*/
public override double area(){
    return base.area()- 0.86 * radius * radius;
	}
}

