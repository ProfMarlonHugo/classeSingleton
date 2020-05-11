using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoDeProjetosSingletonEStatic
{
    static public class Utilitario
    {
        /*Atributos*/
        private static DateTime dataNascimento;
        private static int idade;

        /*Construtor*/
        static Utilitario()
        {
           // DataNascimento = new DateTime(1990, 01, 01);
        }

        public static DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

        public static int Idade
        {
            get
            {
                return (int)DateTime.Today.Subtract(dataNascimento).TotalDays/360;
            }

            set
            {
                idade = value;

            }
        }
    }
}
