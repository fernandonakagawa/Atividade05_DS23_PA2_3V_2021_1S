using System;
using System.Collections.Generic;

namespace Atividade05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 03 e 04
            float volumePiscinaM3 = 1890f;
            float volumePiscinaL = ConversaoDeUnidadesDeVolume.MetrosCubicosParaLitros(volumePiscinaM3);
            Console.WriteLine(volumePiscinaL);

            Console.WriteLine("O volume da piscina em m³ é de " + volumePiscinaM3 + ".\n" +
                "Em litros é de " + volumePiscinaL);
            Console.WriteLine($"O volume da piscina em m³ é de {volumePiscinaM3}.\n" +
                $"Em litros é de {volumePiscinaL}.\n" +
                $"Em pés cúbicos é de {ConversaoDeUnidadesDeVolume.MetrosCubicosParaPesCubicos(volumePiscinaM3)}." +
                $"Em cm³ é de {ConversaoDeUnidadesDeVolume.LitrosParaCentimetrosCubicos(volumePiscinaL)}.");

            //Não há necessidade de criar um objeto novo
            //ConversaoDeUnidadesDeVolume cuv = new ConversaoDeUnidadesDeVolume();
            //cuv.MetrosCubicosParaLitros(10);

            //Exemplo para o exercício 08
            List<Aluno> alunos = new List<Aluno>();
            Aluno a1 = new Aluno("Gustavo");
            alunos.Add(a1);
            Aluno a2 = new Aluno("Henzo");
            alunos.Add(a2);
            Aluno a3 = new Aluno("Guilherme");
            alunos.Add(a3);
            a2.NumeroChamada = -1;
            foreach (Aluno a in alunos)
            {
                Console.WriteLine($"{a.NumeroChamada} {a.Nome}");
            }
            
        }
    }
}
