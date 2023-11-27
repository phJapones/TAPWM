function validarForm() {

    if (document.Form1.elements['txtNome'].value.length < 10) {
        alert("Nome precisa ter no minimo 10 caracteres")
    }

    var email = document.Form1.elements['txtEmail'].value;
    var regex = /\S+@\S+\.\S+/;

    if (!regex.test(email)) {
        alert("Insira um e-mail válido.");
        event.preventDefault();
    }

    if (document.Form1.elements['txtComentario'].value.length < 20) {
        alert("Comentário precisa ter no minimo 10 caracteres");
        event.preventDefault();
    }

    if (!document.Form1.elements['rdSim'].checked && !document.Form1.elements['rdNao'].checked) {
        alert("Responda a pesquisa");
        event.preventDefault();
    }
    else if (document.Form1.elements['rdNao'].checked) {
        alert("Seja bem vindo novamente");
        event.preventDefault();
    }
    else if (document.Form1.elements['rdSim'].checked) {
        alert("Seja bem vindo, volte sempre");
        event.preventDefault();
    }
    else {
        event.preventDefault();
    }
}
function limparCampos() {
    document.getElementById("txtNome").value = "";
    document.getElementById("txtEmail").value = "";
    document.getElementById("txtComentario").value = "";
    document.getElementById("rdSim").checked = false;
    document.getElementById("rdNao").checked = false;
}

document.getElementById("btnLimpar").addEventListener("click", limparCampos);
