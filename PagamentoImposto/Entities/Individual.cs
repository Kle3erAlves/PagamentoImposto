using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoImposto.Entities
{
    class Individual : TaxPayer
    {   //ATRIBUTOS DA SUBCLASSE
        public double HealthExpenditures { get; set; }
        //CONSTRUTOR INICIAL DA SUBCLASSE
        public Individual()
        {

        }
        //CONSTRUTOR PADRÃO DA SUBCLASSE
        public Individual(string name, double anuallncome, double healthExpenditures)
            : base (name, anuallncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        //METODO SUBESCRITO DA SUBCLASSE "INDIVIDUAL" PARA UTILIZAR O METODO ABSTRATO EXISTENTE NA SUPERCLASSE "TAXPAYER"
        public override double Tax()
        {            
                if (Anuallncome < 20000.00)
            {
                return Anuallncome * 0.15 - HealthExpenditures * 0.50;
            }

                else
            {
                return Anuallncome * 0.25 - HealthExpenditures * 0.50;
            }

        }
    }
}
