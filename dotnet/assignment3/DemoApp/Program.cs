using bannerPrice;

class BannerTest{
    public static void Main(string [] args){
    int h = int.Parse(args[0]);
    int w = int.Parse(args[1]);

    Banner b = new Banner(h,w);
    CurvedBanner Cb = new CurvedBanner(h , w , 5);


    Console.WriteLine("the height of banner is = {0} " , h);
    Console.WriteLine("the width of banner is ={0} " , w);
    


    Console.WriteLine("the area of banner is {0} " , b.area());
    Console.WriteLine("the area of curved banner is = {0} " , Cb.area());


    }


}