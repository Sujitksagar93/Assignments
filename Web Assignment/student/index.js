 var students=[];

document.getElementById('btn').onclick=function(){

    var rollNo=document.getElementById('x1').value
    var name=document.getElementById('x2').value
    var age=document.getElementById('x3').value

    var jsObj={

        RollNo:rollNo,
        Name:name,
        Age:age,
    }
    console.log(jsObj)
    students.push(jsObj)
}

document.getElementById('btnn').onclick=function(){
    document.getElementById("t").style.visibility="visible"
            var x="";

            for(var i=0;i<students.length;++i)
            {
                x=x+`
                    <tr>
                    <td>${students[i].RollNo}</td>
                    <td>${students[i].Name}</td>
                    <td>${students[i].Age}</td>
                    </tr>
                  `
            }
            document.getElementById('result').innerHTML=x;
            console.log(x);
}