namespace Tours;

public class PremiumTours {

public double Common (int days, int NoPersons)=> days * NoPersons *1200;
public double Seniors (int days, int NoPersons)=> GetDiscount( days ,  NoPersons)-100;
public double Women (int days, int NoPersons)=> GetDiscount( days ,  NoPersons)-200;

private double GetDiscount(int days , int NoPerson)
{

double total = Common (days, NoPerson);
if ((days>6) && (NoPerson >= 4))
{
    return total - 200 * days * NoPerson;
}
else if (days > 6)
{
    return total - 100 * days * NoPerson;
}
else if (days > 4)
{
    return total - 100 * days * NoPerson;
}
    return days * NoPerson * 1200;
}
}

