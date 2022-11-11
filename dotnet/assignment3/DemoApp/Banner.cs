namespace bannerPrice;

public class Banner{

    private int height;
    private int width;

    public Banner(int h , int w){

        height = h;
        width = w;
    }

    public int Height{
        get { return height;}
        set {height = value;}
    }

    public int Width{
        get {return width;}
        set { width = value;}
    }
    public virtual double area(){
        return height * width;
    }







}



