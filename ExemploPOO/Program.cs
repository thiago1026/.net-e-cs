using System;
using ExemploPOO.interfaces;
using ExemploPOO.Models;
using ExemploPOO.Helper;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
           var caminho = "C:\\TrabalhandoComArquivos";
           FileHelper helper = new FileHelper();
           //helper.ListarDiretorios(caminho);
           helper.ListarArquivosDiretorios(caminho);
           
           
           
           
           
           // ICalculadora calc = new Calculadora();
           // System.Console.WriteLine(calc.Somar(10,20));






            //Computador comp = new Computador();
            
            //System.Console.WriteLine(comp.ToString());





            //Corrente c = new Corrente();
            //c.Creditar(100);
            //c.ExibirSaldo();




            //Calculadora calc = new Calculadora();
            //System.Console.WriteLine("Resultado da primeira soma:" + calc.Somar(10, 10));
            //System.Console.WriteLine("Resultado da segunda soma:" + calc.Somar(10, 10, 10));




            // Professor p1 = new  Professor();
            // p1.Salario = 2000;
            // //p1.Nota = 10;
            // p1.Nome = "bob";
            // p1.Idade = 20;

            // p1.Apresentar();








        //     //valores validos

        //    Retangulo r = new Retangulo();
        //    r.DefinirMediadas(30, 30);
        //    System.Console.WriteLine($"AREA: {r.ObterArea()}");
           
        //    //valores invalidos
           
        //    Retangulo r2 = new Retangulo();
        //    r2.DefinirMediadas(0, 0);
        //    System.Console.WriteLine($"AREA: {r2.ObterArea()}");





            
        //    Pessoa p1 = new Pessoa();
        //    p1.Nome = "bob";
        //    p1.Idade = 20;

        //    p1.Apresentar();
            
        }
    }
}