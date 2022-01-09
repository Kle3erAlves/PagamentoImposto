using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoImposto.Entities
{
    class Company : TaxPayer
    {   //ATRIBUTOS DA SUBCLASSE COMPANY
        public int NumberOfEmployees { get; set; }
        //CONSTRUTOR INICIAL DA SUBCLASSE COMPANY
        public Company()
        {

        }
        //CONSTRUTOR PADRÃO DA SUBCLASSE COMPANY
        public Company(string name, double anuallncome, int numberOfEmployees)
            : base (name, anuallncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        //METODO SUBESCRITO DA SUBCLASSE "COMPANY" PARA UTILIZAR O METODO ABSTRATO EXISTENTE NA SUPERCLASSE "TAXPAYER" 
        public override double Tax()
        {
            if (NumberOfEmployees < 10)
            {
                return Anuallncome * 0.16;
            }

            else
            {
                return Anuallncome * 0.14;
            }
        }
    }
}
