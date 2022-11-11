namespace Math.op;
class MathUtil
{
    public static Boolean isEven(int x)
    {
        if(x % 2 ==0)
        return true;
        return false;
    }

    public static Boolean isOdd(int x)
    {
        if(x % 2 ==0)
        return true;
        return false; 
    }

    public static Boolean isPrime(int x)
    {
        int m;

        if (x==1)
           return false;

        if(x==2 || x==3)
            return true;

        if((x % 2) ==0)
        return false;

        for(m=3; m*m<=x; m=m+2)
        {
            if((m % x )== 0)
            return false;
        }
        return true;
        }

        public static int countPrimes(int x ,int y)
        {
            int term;
            int count = 0;

            for(term = x; term <=y; ++term){

            if(isPrime(term)) {
                ++count;
            }
            }
            return count;

        } 

        public static int reverse(int x)
        {
            int rem=0;
            int reverse =0;
            while(x !=0)
            {
                rem = x % 10;
                reverse = reverse * 10 +rem;
                x = x /10;

            }
            return reverse;
        }

        public static int DigitCount(int x)
        {
            int count =0;
            while(x !=0)
            {
                x /=10;
                ++count;
            }
            return count;
        }

         

        
        
            

               
    }
