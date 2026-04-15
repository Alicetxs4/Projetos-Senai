Console.Write("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

//2. Decisão. Se a idade for 18 ou mais 

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade " + idade);   
}
else
{
    Console.WriteLine("Você é menor de idade " + idade);
}
