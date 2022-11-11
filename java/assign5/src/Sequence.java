package Series;

public abstract class Sequence{

	public abstract double next();

	public double sum(int count){
	
		double total = 0;

		for (int i = 0 ; i<count; i++){
		 
			total += next();
		
		}
		return total;
	}

}
