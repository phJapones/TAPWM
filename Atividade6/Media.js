        function calcularMedia() {
            var nota1 = parseFloat(document.getElementById("nota1").value);
            var nota2 = parseFloat(document.getElementById("nota2").value);
            var nota3 = parseFloat(document.getElementById("nota3").value);

            var media = (nota1 + nota2 + nota3) / 3;

            document.getElementById("media").textContent = media.toFixed(2);

            return media = `nota1, nota2, nota3`;

            alert(exemplo());
            alert(`Digite aqui primeira media:${nota1};
                   Digite aqui a segunda media: ${nota2}; 
                   Digite aqui a terceira media: ${nota3};`)
        }