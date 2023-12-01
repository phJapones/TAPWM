function dividir(a, b) {
    // Verifica se a divisão resulta em NaN
    if (isNaN(a / b)) {
      console.log("Divisão deu NaN");
    } else {
      // Verifica se a divisão resulta em Infinity
      if (!isFinite(a / b)) {
        console.log("Divisão de Infinity");
      } else {
        // Retorna o valor da divisão se não houver NaN ou Infinity
        return a / b;
      }
    }
  }
  
  console.log(dividir(1, 0));      // Deve imprimir "Divisão de Infinity"
  console.log(dividir(0, 0));      // Deve imprimir "Divisão deu NaN"
  console.log(dividir(1, Infinity)); // Deve imprimir "Divisão de Infinity"
  console.log(dividir(4, 2));      // Deve imprimir o resultado da divisão
  