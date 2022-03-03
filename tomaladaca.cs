using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pliniosalgado
{
    class Program
    {
        public struct Data
        {
          public int dia, mes, ano;
          public bool bis, val; 
        }
          static void Main(string[] args)
            {
                
          Console.WriteLine("Digite uma data:");
            
          Data data1 = new Data();
           
          Console.Write("Ano:"); 
          data1.ano = int.Parse(Console.ReadLine());
          Console.Write("Mês: ");
          data1.mes = int.Parse(Console.ReadLine());  
          Console.Write("Dia:");
          data1.dia = int.Parse(Console.ReadLine());

          Console.Clear();

          if(data1.mes > 12 || data1.mes < 1){
            data1.val = false; 
            Console.WriteLine("Data invalida");
          } 
          if(data1.dia < 32 || data1.dia > 0|| data1.mes == 1 || data1.mes == 3 || data1.mes == 5 || data1.mes == 7 || data1.mes == 8 || data1.mes == 10 || data1.mes == 12){
            data1.val = false; 
            Console.WriteLine("Data invalida");
          }
          else if(data1.dia < 31 || data1.dia > 0 || data1.mes == 4 || data1.mes == 6 || data1.mes == 9 || data1.mes == 11){
           data1.val = false; 
           Console.WriteLine("Data invalida"); 
          }
          else{
          if (data1.ano%4==0 && data1.ano %100 != 0 || data1.ano%400==0 ){
            
          data1.bis = true;
          }
          else{
          data1.bis = false;
          }
          if(data1.mes == 2 || data1.dia == 28){
          data1.bis = false;
          }
          }
          }
          Console.WriteLine("{0}/{1}/{2} \n\n", data1.dia, data1.mes, data1.ano);
          Console.ReadKey();
           }
            
        }
    }
