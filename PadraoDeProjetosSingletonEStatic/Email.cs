using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoDeProjetosSingletonEStatic
{
    class Email
    {
        public string origem;
        public string destino;
        public string assunto;
        public string mensagem;

        static Email instancia;

        private Email() { }

        public static Email Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Email();
                }
                return instancia;
            }
        }
    }
}
