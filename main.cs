using System;
class Program {
  public static void Main (string[] args) {
    Int16 num;
    String entrada;
    //Escreval
    Console.WriteLine("Digite um nro");
    //Leia
    entrada=Console.ReadLine();
    //converte a entrada em texto no formato númerico
    num = Int16.Parse(entrada);
//se(num%2=0) entao 
    //C# a comparação é feita com ==
    if(num%2==0)
    {
      Console.WriteLine("Número Par");
    }
    else{
      Console.WriteLine("Nro Impar");
    }
    
    
    }
}