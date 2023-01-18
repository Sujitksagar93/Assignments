document.getElementById('btn').onclick=function(){

    var days=document.getElementById('x1').value
    var person=document.getElementById('x2').value
    var type=document.getElementById('x3').value

    console.log(days,person,type);

    switch(type)
    {
        case "Economy" : 
             
            result= person * days* 500;
            break;
        
        case "Business" :

            if(days>3)
            {
                result= (days* person *1000)-( person* 100);
            }
            else(
                result= (days* person *1000)
            )
            break

        case  "Delux" : 
                
             if(days>5)
            {
            result= (days* person *2000)-( person* 250);
             }
             else(
                result= (days* person *2000)
            )
            break
        
        default:
            break;

    }
    document.getElementById('result').innerHTML= 'Total Cost =&#8377;'+result;

}