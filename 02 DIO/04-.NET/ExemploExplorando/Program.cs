﻿using ExemploExplorando;
using ExemploExplorando.Models;
using System.Data;
using System.Globalization; //Alterando a localização do código

//Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();
//adicionar valor
estados.Add("SP", "SÃO PAULO");
estados.Add("DF", "DISTRITO FEDERAL");
estados.Add("BA", "BAHIA");

// //Acessar valor
// Console.WriteLine(estados["DF"]);

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

// //Remover valor
// estados.Remove("BA");

// //Mudar valor
// estados["SP"] = "São Paulo - é uma Estado rico";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

//verificando valor
string chave = "BA";
Console.WriteLine($"verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe: {chave}");
}



















// //Pilha 
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }
















// // Filas 
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }
// //fila.Dequeue();
// //Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// fila.Enqueue(5);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }









//new ExemploExcecao().Metodo1();

// //tratamento de exceção
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado."  + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// //Bloco finally (sempre aparece no final de um execução de código)
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }












// //TryParseExact
// string dataString = "2024-10-16 21:29";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversao com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }







// DateTime data = DateTime.Now;
// //Só data
// Console.WriteLine(data.ToShortDateString());
// //Só hora
// Console.WriteLine(data.ToShortTimeString());


// DateTime data = DateTime.Parse("30/10/2022 21:00");
// Console.WriteLine(data);








// //Formatando o tipo DateTime
// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd-MM-dd HH:mm"));




















////Alterando a localização do código
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-us") //Modo 01

////Concatenação de valores
//decimal valorMonetario = 1980.00m;
//double porcentagem = .3421;

////Formatação personalizada
//Console.WriteLine(porcentagem.ToString("p"));

////Formatação personalizada N ou C
//Console.WriteLine(valorMonetario.ToString("N2"));

//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));//Modo 02

//Console.WriteLine($"{valorMonetario:C}");//Modo 01







// //Concatenação de valores
// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;
// Console.WriteLine(resultado);











// // Instanciando a classe Pessoa usando um Construdor
// Pessoa p1 = new Pessoa(nome: "Leandro", sobrenome: "Vilar");

// // Instanciando a classe Pessoa
// Pessoa p2 = new Pessoa();
// // Atribuindo valores às propriedades
// p2.Nome = "Renata";
// p2.Sobrenome = "Vilar";

// // Instanciando a classe Curso
// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";

// // Inicializando a lista de alunos
// cursoDeIngles.Alunos = new List<Pessoa>();

// //Metodo adicionar aluno
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// //Metodo listar alunos
// cursoDeIngles.ListarAlunos();
















// // Instanciando a classe Pessoa
// Pessoa p1 = new Pessoa();

// // Atribuindo valores às propriedades
// p1.Nome = "Leandro";
// p1.Sobrenome = "Vilar";
// p1.Idade = 44;

// // Chamando o método Apresentar
// p1.Apresentar();
