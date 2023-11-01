//1) metodo construtor
//escolha = prompt("Pedra, papel ou tesoura?".toLowerCase());
function calcularArea() {
    function Retangulo(x, y) {
        this.x = x;
        this.y = y;
        var resultado;

        this.Calcular = function () {
            resultado = this.x * this.y;
            return resultado;
        }
    }

    var base = prompt("Informe a base do retangulo: ");
    var altura = prompt("Informe a altura do retangulo: ");
    varcalculo = new Retangulo(base, altura);
    alert(varcalculo.Calcular());
}
function mostrarDados() {
    function Conta() {
        var nome_correntista;
        var banco;
        var num_conta;
        var saldo;
        this.setNome_correntista = function (value) {
            this.nome_correntista = value;
        }
        this.getNome_correntista = function () {
            return this.nome_correntista;
        }
        this.setBanco = function (value) {
            this.banco = value;
        }
        this.getBanco = function () {
            return this.banco;
        }
        this.setNum_conta = function (value) {
            this.num_conta = value;
        }
        this.getNum_conta = function () {
            return this.num_conta;
        }
        this.setSaldo = function (value) {
            this.saldo = value;
        }
        this.getSaldo = function () {
            return this.saldo;
        }
    }

    function Corrente() {
        Conta.call(this);
        var saldoEspecial;

        this.setSaldoEspecial = function (value) {
            saldoEspecial = value;
        }

        this.getSaldoEspecial = function () {
            return saldoEspecial;
        }
    }

    Corrente.prototype = Object.create(Conta.prototype);

    function Poupanca() {
        Conta.call(this);

        var juros, dataVencimento;

        this.setJuros = function (value) {
            juros = value;
        }

        this.getJuros = function () {
            return juros;
        }

        this.setDataVencimento = function (value) {
            dataVencimento = value;
        }

        this.getDataVencimento = function () {
            return dataVencimento;
        }
    }

    Poupanca.prototype = Object.create(Conta.prototype);

    var objContaCorrente = new Corrente();
    objContaCorrente.setNome_correntista('Breno');
    objContaCorrente.setBanco('Banco do Brasil');
    objContaCorrente.setNum_conta('123456');
    objContaCorrente.setSaldo(100000);
    objContaCorrente.setSaldoEspecial(50000);

    var objContaPoupanca = new Poupanca();
    objContaPoupanca.setNome_correntista('Breno2');
    objContaPoupanca.setBanco('Caixa Econômica');
    objContaPoupanca.setNum_conta('654321');
    objContaPoupanca.setSaldo(300000);
    objContaPoupanca.setJuros(0.01);
    objContaPoupanca.setDataVencimento('15/10/2023');

    console.log(objContaCorrente.getNome_correntista(), objContaCorrente.getBanco(), objContaCorrente.getNum_conta(), objContaCorrente.getSaldo(), objContaCorrente.getSaldoEspecial());
    console.log(objContaPoupanca.getNome_correntista(), objContaPoupanca.getBanco(), objContaPoupanca.getNum_conta(), objContaPoupanca.getSaldo(), objContaPoupanca.getJuros(), objContaPoupanca.getDataVencimento());
}