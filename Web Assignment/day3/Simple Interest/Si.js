 function demoFunc(){

    var amount=document.getElementById('x1').value;
    var interest=document.getElementById('x2').value;
    var years=document.getElementById('x3').value;
    console.log(typeof amount,typeof interest,typeof years);
     
   amt=parseInt(amount);
   roi=parseInt(interest);
   years=parseInt(years);
    console.log(c);
    var c= (amount*interest*years)/100;

    console.log(typeof amt,typeof roi,typeof years);
    var x="";
    var y=1;

    for(var i=0;i<y;i++)
   { 
    x=x + `
    <tr>
        <td>${amt}</td>
        <td>${interest}</td>
        <td>${years}</td>
        
    </tr>
`
   }
    console.log(x);
    document.getElementById('result').innerHTML=x;

   
}
function demo(){
    var d=document.getElementById('x4').innerHTML=Date();
    console.log(d);
}