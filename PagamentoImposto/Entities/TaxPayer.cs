using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoImposto.Entities
{
    abstract class TaxPayer
    {   //ATRIBUTOS DA SUPERCLASSE
        public string Name { get; set; }
        public double Anuallncome { get; set; }
        //CONSTRUTOR BASICO DA SUPERCLASSE
        public TaxPayer()
        {

        }
        //CONSTRUTOR PADRÃO DA SUPERCLASSE
        public TaxPayer(string name, double anuallncome)
        {
            Name = name;
            Anuallncome = anuallncome;
        }
        //METODO abstrata TAXA DA SUPERCLASSE
        public abstract double Tax();        

    }
}
