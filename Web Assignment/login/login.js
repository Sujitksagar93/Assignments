function myLogin(){

    var username=document.getElementById('user').value;
    var password=document.getElementById('pass').value;

    console.log(username,password);

    if(username=="" && password =="")
    {   
        var a ="Enter user name paswword"
        document.getElementById('msg').innerHTML=a;
    }

}

function demo(){

    var b = document.getElementById('x1').innerHTML=Date();
    console.log(b);
}