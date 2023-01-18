
var timer;
function startInterval(){
    // var timer= null;
    var date= new Date();
    timer= setInterval(function(){

        const date = new Date();
        document.getElementById('result').innerHTML= date.toLocaleTimeString();
    }, 1000);
    
}

function stopInterval(){

    clearInterval(timer);
}