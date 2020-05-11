using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoDeProjetosSingletonEStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilitario util = new Utilitario();
            Utilitario.DataNascimento = new DateTime(1988,01,14);
            int i = Utilitario.Idade;

            Email email = Email.Instancia;
            email.mensagem = "Teste";

            Email email2 = Email.Instancia;
            Console.WriteLine(email2.mensagem);

        }
    }
}
