using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int mes;
            int dia;
            int periodo;
            
            
           



            Console.WriteLine("Bem-Vindo ao Programa De Passagens Aéreas Zupper");
            Console.WriteLine("Digite Seu Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Meses Disponiveis Para a Compra:");
            Console.WriteLine($"• 08 - Agosto");
            Console.WriteLine($"• 09 - Setembro");
            Console.WriteLine($"• 10 - Outubro");
            mes = Int32.Parse(Console.ReadLine());

            if (mes == 8)
                if (mes == 9)
                    if (mes == 10)
                    {
                        Console.WriteLine("Anotado Com Sucesso!");
                    }

                        else
                            {
                               Console.WriteLine("Mês Inválido!");
                               
                        return;
                            
                            }

            Console.WriteLine("Dias Disponiveis Para a Compra:");
            Console.WriteLine("• 6 - Seis");
            Console.WriteLine("• 21 - Vinte e um");
            dia = Int32.Parse(Console.ReadLine());

            if (dia == 6)
                if (dia == 21)
                {
                    Console.WriteLine("Anotado Com Sucesso!");
                }

            else
                {

                    Console.WriteLine("Dia Inválido!");
                    return;
                    Main(null);
                }

            Console.WriteLine("Período Que Deseja Comprar:");
            Console.WriteLine("• Manhã");
            Console.WriteLine("• Tarde");
            Console.WriteLine("• Noite");
            periodo = Int32.Parse(Console.ReadLine());

            if (periodo == 1 )
                if (periodo == 2)
                    if (periodo == 3)
                    {
                        Console.WriteLine("Anotado Com Sucesso!");
                    }

                    else
                    {

                        Console.WriteLine("Período Inválido!");
                        return;
                        Main(null);
                    }

            Console.WriteLine("Parabêns Sua Passagem Foi Comprada Com Sucesso!!!\n\n");
            Console.WriteLine("Recibo:");
            Console.WriteLine($"---Mês {mes}, Do Dia {dia}, No Período {periodo}");

            Console.ReadKey();



        }

    }
}
