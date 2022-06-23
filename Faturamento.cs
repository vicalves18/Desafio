using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        double menorValor = 0, maiorValor = 0, soma = 0, media = 0;


        List<dados> diaMes = new List<dados>()
        {
            new dados() {dia = 1, valor = 22174.1664},
            new dados() {dia = 2, valor = 24537.6698},
            new dados() {dia = 3, valor = 26139.6134},
            new dados() {dia = 4, valor = 0.0},
            new dados() {dia = 5, valor = 0.0},
            new dados() {dia = 6, valor = 26742.6612},
            new dados() {dia = 7, valor = 0.0},
            new dados() {dia = 8, valor = 42889.2258},
            new dados() {dia = 9, valor = 46251.174},
            new dados() {dia = 10, valor = 11191.4722},
            new dados() {dia = 11, valor = 0.0},
            new dados() {dia = 12, valor = 0.0},
            new dados() {dia = 13, valor = 3847.4823},
            new dados() {dia = 14, valor = 373.7838},
            new dados() {dia = 15, valor = 2659.7563},
            new dados() {dia = 16, valor = 48924.2448},
            new dados() {dia = 17, valor = 18419.2614},
            new dados() {dia = 18, valor = 0.0},
            new dados() {dia = 19, valor = 0.0},
            new dados() {dia = 20, valor = 35240.1826},
            new dados() {dia = 21, valor = 43829.1667},
            new dados() {dia = 22, valor = 18235.6852},
            new dados() {dia = 23, valor = 4355.0662},
            new dados() {dia = 24, valor = 13327.1025},
            new dados() {dia = 25, valor = 0.0},
            new dados() {dia = 26, valor = 0.0},
            new dados() {dia = 27, valor = 25681.8318},
            new dados() {dia = 28, valor = 1718.1221},
            new dados() {dia = 29, valor = 13220.495},
            new dados() {dia = 30, valor = 8414.61},
        };
                    
        menorValor = diaMes.Select(i => i.valor).Min();
    
        maiorValor = diaMes.Select(i => i.valor).Max();
    
        soma = diaMes.Sum(i => i.valor);
        media = diaMes.Average(i => i.valor);
        
        Console.WriteLine("menor valor: " + menorValor);
        Console.WriteLine("maior valor: " + maiorValor);
        Console.WriteLine("soma: " + soma);
        Console.WriteLine("media: " + media);
        
        var menoresDias = diaMes.Where(i => i.valor == menorValor).Select(i => i.dia);
        Console.Write("Menores dias: ");    
        foreach(int dia in menoresDias){
                Console.Write(dia + " ");
            };
        var maioresDias = diaMes.Where(i => i.valor == maiorValor).Select(i => i.dia);
        Console.Write("Maiores dias: ");
            foreach(int dia in maioresDias){
                Console.Write(dia + " ");
            };
        
        Console.ReadLine();
    }
}