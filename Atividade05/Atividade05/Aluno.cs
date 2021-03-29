using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade05
{
    class Aluno
    {
        private static int quantidadeAlunos = 10;

        private int _numeroChamada;
        private string _nome;
        public int NumeroChamada 
        { 
            get => _numeroChamada; 
            set 
            {
                if (value <= 0) _numeroChamada = 1;
                else _numeroChamada = value; 
            } 
        }
        public string Nome { get => _nome; set => _nome = value; }

        public Aluno(string nome)
        {
            this.Nome = nome;
            this.NumeroChamada = quantidadeAlunos++;
        }

        
    }
}
