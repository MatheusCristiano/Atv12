using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12Teste
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Snome /*sobrenome*/ { get; set; }
        public DateTime DataNas { get; set; }
        public int Codigo { get; set; }

        public DateTime Data;

        public int Idade()
        {
            var b = DateTime.Now;
            Data = b;
            var i = Convert.ToInt32(Data.Year - DataNas.Year);
            return i;
        }

        public string NameComp()
        {
            return "" + Nome + " " + Snome + "";
        }

        public int validarNome()
        {
            int i = 0;
            string n = Nome;
            string s = Snome;

            if (n.Contains(" Ç") || n.Contains(" ç") || s.Contains(" Ç") || s.Contains(" ç"))
            {
                Console.WriteLine("Este nome é não pode ser utilizado pois tem a letra 'Ç' que é inválido");
                i = +1;
            }
            if (n.Contains("@") || s.Contains("@"))
            {
                Console.WriteLine("Este nome não podeser utilizado pois contém caracter '@' que é inválido");
                i = +2;
            }
            return i;
        }

        public string ErroVal(int i)
        {
            string m;
            if (validarNome() == 1)
            {
                m = "ERROR POR 'Ç'";
                return m;
            }
            else if (validarNome() == 2)
            {
                m = "ERROR POR '@'";
                return m;
            }

            return " ";
        }
    }
}