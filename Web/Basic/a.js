function showMessage(){
  
    document.body.children[0].innerHTML = document.getElementById('inpt').value;
}

function slider()
{
    var x = document.getElementById("myRange").value;
    document.body.children[0].innerHTML = x;
}
//generate the random number
function randomNumber()
{
    var x = Math.floor(Math.random() * 100);
    document.getElementById('inpt').value = x;
}

//function to generate the fibonacci series
function fibonacci()
{
    var x = document.getElementById('inpt').value;
    var a = 0;
    var b = 1;
    var c = 0;
    var fib = [];
    fib[0] = a;
    fib[1] = b;
    for(var i = 2; i < x; i++)
    {
        c = a + b;
        a = b;
        b = c;
        fib[i] = c;
    }
    document.body.children[0].innerHTML = fib;
}