using System;

public class NotasAlunos
{
    public static void Main()
    {
        //Matriz 3x2 (3 alunos, 2 notas cada)
        double[,] notasAlunos = new double[3,2];

        //Atribuição de Valores
        notasAlunos[0,0] = 8.5; //Aluno 1, Nota 1
        notasAlunos[0,1] = 7.0; //Aluno 1, Nota 2
        notasAlunos[1,0] = 6.0; //Aluno 2, Nota 1
        notasAlunos[1,1] = 9.5; //Aluno 2, Nota 2
        notasAlunos[2,0] = 10.0; //Aluno 3, Nota 1
        notasAlunos[2,1] = 8.0; //Aluno 3, Nota 2

        Console.WriteLine($"Relátório de Notas: ");

        //Percorrer as Linhas (Alunos)
        for(int i = 0; i < 3; i++)
        {
            Console.Write($"Aluno {i + 1}: ");
             
            for(int j = 0; j < 2; j++)
            {
                Console.WriteLine($"[Nota {j + 1}: {notasAlunos[i, j]}]");
            }
            Console.WriteLine(); //Quebra uma linha para o próximo aluno
        }
    }
}