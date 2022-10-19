// Двумерные массивы
// string[строки , столбцы] table = new string[2,3];
// int[,] matrix = new int[5,8]; [5-строки, 8-столбцы]
/*string[,] table = new string[2,5];
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,4]

table[1, 2] = " слово";

for (int rows = 0; rows < 2; rows++)

{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/
/*
int[,] matrix = new int[3,4];

for (int i = 0; i < 3 ; i++) // 3 - можно заменить matrix.GetLength(0)
{
    for (int j = 0; j < 4; j++) // 4 - можно заменить matrix.GetLength(1)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
*/

/*
void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0) ; i++)
     
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
         Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}


int[,] matrix = new int[3,4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
// Как представить черно-белое изображение 
// int[,] pic = new int[23,25];
// 0 - закрашенный пиксель
// 1 - незакрашенный пиксель
// Как закрасить область?
// (x,y) - изначальная точка, (x-1,y) - точка вверх, (x,y-1) - точка влево,
// (x+1,y) - точка вниз, (x,y+1) - точка вправо

/*
int[,] pic = new int[23,25];

void PrintImage(int[,] image)
{

    for (int i = 0; i < image.GetLength(0) ; i++)
     
    {
        for (int j = 0; j < image.GetLength(1); j++) 
        {
        // Console.Write($"{image[i, j]} ");
        if(image[i,j] == 0) Console.WriteLine($" ");
        else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row,col] = 1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}
PrintImage(pic);
FillImage(13,13);
PrintImage(pic);
*/
// Что такое рекурсия? - функция которая вызывает сама себя
// Факториал : 5! = 5*4*3*2*1 (5*4!)(4*3!)(3*2!) и тд.

// Метод который будет принимать число факториал которого нужно вычислить 
//(принимает число и возвращает факториал)

/*
int Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(3));// 1*2*3=6
/*
double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/
// Фибоначи : 1 1 2 3 5 8 13 21 ...  f(n) = f(n-1) + f(n-2)
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

/*
double Fibonacci(int n) // Можно сделать int Fibonacci когда мало цифр (до 10)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
*/
