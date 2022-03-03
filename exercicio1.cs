using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papotimonenho{ 
  
class Program{
public struct Alunos{
public string nome;
public double nota1;
public double nota2;
public double soma;
public double media;
public string situacao;

static void Main(string[] args){
const int bom = 15;
Alunos[] alunos = new Alunos[bom];

for (int x = 0; x < 15; x++){
Console.WriteLine("Digite o NOME do {0}ºaluno:", x + 1);
alunos[x].nome = Console.ReadLine();
  
Console.WriteLine("Digite a 1ºNOTA do {0}°aluno:", x+1);
alunos[x].nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a 2ºNOTA do {0}°aluno:", x+1);
alunos[x].nota2 = double.Parse(Console.ReadLine());

alunos[x].soma = (alunos[x].nota1 + alunos[x].nota2);
alunos[x].media = (alunos[x].soma/2);

Console.Clear();
}

Console.Clear();
for (int x = 0; x < 15; x++){
Console.WriteLine("{0}ºAluno: {1}", x+1, alunos[x].nome);
Console.WriteLine("1°Nota: {0}", alunos[x].nota1);
Console.WriteLine("2°Nota: {0}", alunos[x].nota2);
Console.WriteLine("Média: {0}", alunos[x].media);
if (alunos[x].media >= 7){
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Situação: Aprovado!");
Console.ResetColor();
}
else{
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Situação: Reprovado!");
Console.ResetColor();
}
Console.WriteLine("-----------------------"); 

Console.ReadLine();
}

}
}
}
}
