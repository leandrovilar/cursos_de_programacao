using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    //Class Curso
    public class Curso
    {
        //Propiedades
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //Metodo adicionar alunos
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
        //Metodo contar alunos
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        //Metodo Remover Alunos
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        //Metodo listar alunos
        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}