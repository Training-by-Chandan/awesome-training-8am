function showMessage(){
  
    document.body.children[0].innerHTML = document.getElementById('inpt').value;
}

function slider()
{
    var x = document.getElementById("myRange").value;
    document.body.children[0].innerHTML = x;
}