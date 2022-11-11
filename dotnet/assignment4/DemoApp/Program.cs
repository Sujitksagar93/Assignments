using Series;
class Program{
	
	public static object compute(Sequence info, int count){

        if(info is IResetable p)
        p.Reset();
	
		return info.sum(count)/count;
	}

	public static void Main(string[] args){
	
	int n = int.Parse(args[0]);
	
	var a = new LinearSequence(2, 5);
	var b = new PowerSequence(3);

	Console.WriteLine("First Linear Sequence computation result = {0}",Program.compute(a,n));
	Console.WriteLine("Second  Linear Sequence computation result = {0}",Program.compute(a,n));
	Console.WriteLine("First Power Sequence computation result = {0}",Program.compute(b,n));
	Console.WriteLine("Second Power Sequence computation result = {0}",Program.compute(b,n));


	}


}
