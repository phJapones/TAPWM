function comeco(){
    document.getElementById("texto").innerHTML = "Janela Fechada";
    document.getElementById('imagem').src = "fechada.jpeg";
}

function abrir(){
    document.getElementById('imagem').src = "aberta.jpeg";
    document.getElementById("texto").innerHTML = "Janela aberta";
}
function fechar(){
    document.getElementById('imagem').src = "fechada.jpeg";
    document.getElementById("texto").innerHTML = "Janela Fechada";
}
function quebrar(){
    document.getElementById('imagem').src = "quebrada.jpeg";
    document.getElementById("texto").innerHTML = "Janela Quebrada";
}