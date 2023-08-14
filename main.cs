using System;
var opcao = string.Empty;
var valor_1 = 10.0;
var valor_2 = 10.0;
var resultado = 0.0; 
var terminar = false;
  
do {
Console.Clear();
Console.WriteLine("CALCULDARA BETA ");
Console.WriteLine("1 - Somar (+)");
Console.WriteLine("2 - subtração (-)");
Console.WriteLine("3 - multiplicação (*)");
Console.WriteLine("4 - divisão (/)");
Console.WriteLine("5 - Sair");  
Console.WriteLine("\nEscolha uma das opções acima: ");

opcao = Console.ReadLine();
  
if(opcao == "5") {
Console.WriteLine("Obrigado por usar esta calculadora");
terminar = true;
break;
} else if( Convert.ToSingle(opcao) <= 5 && Convert.ToSingle(opcao) > 0){ 

Console.WriteLine("Qual é o primeiro valor");
valor_1 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Qual é o segundo valor");
valor_2 = Convert.ToSingle(Console.ReadLine());
  

if (opcao == "1") {
resultado = valor_1 + valor_2;
Console.WriteLine("O calculo solicitado " + valor_1 + " + " + valor_2);
}
else if(opcao == "2") {
resultado = valor_1 - valor_2;
Console.WriteLine("O calculo solicitado " + valor_1 + " - " + valor_2);   
}
 else if(opcao == "3") {
resultado = valor_1 * valor_2;
Console.WriteLine("O calculo solicitado " + valor_1 + " * " + valor_2);
}
else if(opcao == "4") {
resultado = valor_1 / valor_2;
Console.WriteLine("O calculo solicitado " + valor_1 + " / " + valor_2); 
};
  
Console.WriteLine(resultado);  
Console.WriteLine("Acione [enter] para fazer uma nova operação...");
Console.ReadKey();  
}
else {
  Console.WriteLine("Escolha um valor valido");
  Console.WriteLine("Acione [enter] para continuar...");
  Console.ReadKey();
};
}
  
while (!terminar);

