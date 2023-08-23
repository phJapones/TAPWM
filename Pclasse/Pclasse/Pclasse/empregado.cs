using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasse
{
    abstract class Empregado
    {
        private int matricula;//atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula //propriedade
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }
        public char HomeOficce
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }
        //métodos

        public string VerificaHome()//método
        {
            if (HomeOficce == 'S')
                return "Empregado trabalha em home oficce";
            else
                return " Empregado NÃO trabalha em home office";
        }

        //representa um intervalo e tempo 
        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract
                (DataEntradaEmpresa);

            return (span.Days);
        }
        public abstract double SalarioBruto();
    }
}
