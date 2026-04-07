
/* 1. Construa um programa que lê uma opção conforme
abaixo (usar estrutura SWITCH) e o salário atual do
funcionário, calcula e exibe o novo salário: */


char opcao;
double salario, novosalario;

Console.WriteLine("Digite seu salario atual: ");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a opção (A, B ou C): ");
opcao = char.Parse(Console.ReadLine().ToUpper());

switch (opcao)
{
    case 'A':
        novosalario = salario + (salario * 0.08);
        Console.WriteLine($"Novo salário: {novosalario:C}");
        break;

    case 'B':
        novosalario = salario + (salario * 0.11);
        Console.WriteLine($"Novo salário: {novosalario:C}");
        break;

    case 'C':
        if (salario <= 2000)
        {
            novosalario = salario + 550;
        }
        else
        {
            novosalario = salario + 400;
        }
        Console.WriteLine($"Novo salário: {novosalario:C}");
        break;

    default:
        Console.WriteLine("Opção inválida!");
        break;
} 

/* 2. Faça um programa para calcular e imprimir o valor de Y,
dado um valor de X: */

double x, y;

Console.WriteLine("Digite o valor de X para descobrir o valor de Y: ");
x = double.Parse(Console.ReadLine());
if (x <= 1){
    y = 1;
    Console.WriteLine($" Y é : {y}");

}
else if ( x <= 2){
    y = 2;
    Console.WriteLine($"Y é: {y}");
}
else if (x <= 3){
    y = Math.Pow(x,2);
    Console.WriteLine($"Y é: {y}");
}
else{
    y = Math.Pow (x,3);
    Console.WriteLine($"Y é :{y}");
} 


 /* 3. Crie um programa que simule uma calculadora simples. O
usuário deve fornecer dois números e uma operação
(adição, subtração, multiplicação, divisão). O programa deve
executar a operação correspondente e exibir o resultado. */

char operacao;
double n1, n2, resultado;

Console.WriteLine("Digite o primeiro numero: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digie o operador '+', '-', '/', '*':" );
operacao = char.Parse(Console.ReadLine());

switch (operacao){
    case '+':
    resultado = n1 + n2;
    Console.WriteLine($"O numero {n1} + {n2} = {resultado}");
    break;

case '-':
 resultado = n1 - n2;
     Console.WriteLine($"O numero {n1} - {n2} = {resultado}");
     break;

case '*':
 resultado= n1 * n2;
    Console.WriteLine($"O numero {n1} * {n2} = {resultado}");
    break;

case '/':
resultado = n1 / n2;
    Console.WriteLine($"O numero {n1} / {n2} = {resultado}");
    break;

    default: Console.WriteLine("Operação invalida");
    break;
    }
    


