/* Внутри класса Answer напишите метод ShowCube, 
который принимает на вход число (N) 
и выводит таблицу кубов чисел от 1 до N (включительно) 
каждое на новой строке. */



using System.Runtime.Versioning;

void ShowCube(int N)
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine(count * count * count);
        count++;
    }
}


Console.WriteLine("Digit input from user:");
int userNum = Convert.ToInt32(Console.ReadLine());
ShowCube(userNum);
