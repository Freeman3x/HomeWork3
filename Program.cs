//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*void Polindrom(int N)
{
 int A = N / 10000;
 int B = N % 10;
 int C = N / 1000 % 10;
 int D = N % 100 / 10;
 if(A == B && C == D ) Console.WriteLine($"{N}-> да");
 else Console.WriteLine($"{N}-> нет");
}

Console.WriteLine("Imrut number");
int user_number = Convert.ToInt32(Console.ReadLine());
Polindrom(user_number);
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*double Prog(int x1,int y1,int z1,int x2,int y2,int z2)
{    
     double lengthAB = Math.Round(Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1)), 3);
     return lengthAB;
}

Console.WriteLine("Imput X coordinat of A:");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput Y coordinat of A:");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput Y coordinat of B:");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput Y coordinat of B:");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput Z coordinat of A:");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Imput Z coordinat of B:");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = Prog(xA,yA,xB,yB,zA,zB);
Console.WriteLine($"Disttance AB is {dist}");
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*void Cube(int N)
{
    int A = 1;
    while(A <= N)
    {
      int B = A * A * A;
      Console.Write($"{B},");
      A++; 
    }
}

Console.WriteLine("Imrut number");
int user_number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{user_number}-> ");
Cube(user_number);
*/