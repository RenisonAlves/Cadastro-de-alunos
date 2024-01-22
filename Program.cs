using CadastrarAlunos.Models;

Console.WriteLine("Qual seu nome? ");
string Nome = Console.ReadLine();

Console.WriteLine("Sua idade? ");
int Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Endereço? ");
string Endereco = Console.ReadLine();
var a1 = new Aluno(Nome, Idade, Endereco);

string CaminhoDoArquivo = @"C:\Users\miste\Desktop\Arq-Reni\projetosParaGitC#\alunos.txt";
FileStream RegistroDeAlunos = File.Create(CaminhoDoArquivo);
RegistroDeAlunos.Close();

bool arquivoExistente = File.Exists(CaminhoDoArquivo);

