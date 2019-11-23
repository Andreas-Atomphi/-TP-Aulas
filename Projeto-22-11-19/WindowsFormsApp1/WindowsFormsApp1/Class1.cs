using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Produto
    {
        //Declara as variáveis
        private string nome;
        private double preco;
        private double codBarras;

        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public double CodBarras { get => codBarras; set => codBarras = value; }

        //Cria uma função/ método para a classe
        string getNome ()
        {
            return Nome;
        }
    }
}
