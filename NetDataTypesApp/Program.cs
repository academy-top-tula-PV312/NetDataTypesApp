//Console.WriteLine("Hello, World!");

//bool f1, f3;
//Boolean f2;

//f1 = true;
//f2 = false;
//f3 = 20 > 0;

//byte b1 = 0xFF;
//Byte b2 = 0b11011011;

//Console.WriteLine(byte.MaxValue);

//int n = 525;
//byte m = (byte)n;
//Console.WriteLine(m);

//string snum = "-100";
//int num = Int32.Parse(snum);
//Console.WriteLine(int.Abs(num));

//int innum = Int32.Parse(Console.ReadLine());

//double x = Double.Parse(Console.ReadLine());

//double y = Convert.ToDouble(Console.ReadLine());

//object o = 145;
//o = 6556.786;
//o = "jhgghf";
//o = true;

//string str = "Hello world";

//o = str;
//x = (double)o;

//var a = 100U;


//int a = 10;
//int b = 20;

//if(a < 0 || ++b > 0)
//    Console.WriteLine("way 1");

//Console.WriteLine(b);

//do
//{

//} while (true);

//while(false)
//{

//}

//for(int i = 0; i < 10; i++)
//{

//}

//foreach(var c in "Hello")
//{

//}

//int[] array = new int[10];
////int* arr = new int[10];

//Random random = new Random();

//for (int i = 0; i < array.Length; i++)
//    array[i] = random.Next() % 100;

//foreach(var item in array)
//    Console.Write(item + " ");
//Console.WriteLine();

//int[] numbers1 = new int[5] { 10, 20, 30, 40, 50 };
//int[] numbers2 = new int[] { 10, 20, 30, 40, 50 };
//int[] numbers3 = new[] { 10, 20, 30, 40, 50 };
//int[] numbers4 = { 10, 20, 30, 40, 50 };

//string[] names = { "Tommy", "Bobby", "Sammy" };

//int[] numbers5 = [ 10, 20, 30, 40, 50 ];
//int[] empty = [];

//for(int i = 1; i <= numbers1.Length; i++)
//    //Console.Write(numbers1[numbers1.Length - i] + " ");
//    Console.Write(numbers1[^i] + " ");


//int[,] matrix = new int[2, 3]; //{ { 1, 2, 3 }, { 4, 5, 6 } };
//int[,,] cube = new int[3, 4, 5];

//int[][] zubematrix = new int[3][];
//for (int i = 0; i < zubematrix.Length; i++)
//    zubematrix[i] = new int[i + 2];
////int** zm = new int*[3];

Random random = new Random();

//int[,] matrix = new int[3, 4];
//int rows = matrix.GetLength(0);
//int columns = matrix.GetLength(1);

//for(int i = 0; i < rows; i++)
//    for (int j = 0; j < columns; j++)
//        matrix[i, j] = random.Next() % 100;

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//        Console.Write(matrix[i, j] + "\t");
//    Console.WriteLine();
//}
//Console.WriteLine();

//int[][] zmatrix = new int[3][];
//for (int i = 0; i < zmatrix.Length; i++)
//{
//    zmatrix[i] = new int[2 + random.Next(3)];
//    for (int j = 0; j < zmatrix[i].Length; j++)
//        zmatrix[i][j] = random.Next() % 100;
//}

//for (int i = 0; i < zmatrix.Length; i++)
//{
//    for (int j = 0; j < zmatrix[i].Length; j++)
//        Console.Write(zmatrix[i][j] + "\t");
//    Console.WriteLine();
//}

//int[] array = new int[5];
//for(int i = 0; i < array.Length; i++)
//{
//    array[i] = random.Next() % 100;
//    Console.Write(array[i] + " ");
//}
//Console.WriteLine("\n" + ArraySum(array));

//int n = 1;
//MethodRef(ref n);
//Console.WriteLine(n);

//int m;
//MethodOut(out m);

//int k = 1;
//MethodIn(in k);

//int[] arr = new[] { 1, 2, 3, 4, 5 };
//Console.WriteLine(Sum(arr));
//Console.WriteLine(Sum(1, 2));
//Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7));
//Console.WriteLine(Sum(10));

//Console.WriteLine(SumInit(1000, 1, 2, 3, 4, 5, 6, 7));

string name = "Jim";

switch(name)
{
    case "Tom":
        Console.WriteLine("Name Tommy"); break;
    case "Bob":
        Console.WriteLine("Name Bobby"); break;
    case "Sam":
        Console.WriteLine("Name Sammy"); break;
}

Console.WriteLine(MathOperation(10, 20, '/'));

TypeWay way = TypeWay.Forward;

//-------------------------------------------

int ArraySum(int[] array)
{
    int result = 0;
    foreach(var item in array)
        result += item;
    return result;
}

void MethodRef(ref int x)
{
    x = 100;
}

void MethodRefRead(ref readonly int x)
{
    int y = x;
}

void MethodOut(out int x)
{
    x = 100;
}

void MethodIn(in int x)
{
    int y = x;
}

int Sum(params int[] array)
{
    int result = 0;
    foreach (var item in array)
        result += item;
    return result;
}

int SumInit(int init, params int[] array)
{
    int result = init;
    foreach (var item in array)
        result += item;
    return result;
}

long Factorial(int n)
{
    if (n == 0) return 1;
    return Factorial(n - 1) * n;
}

int MathOperation(int a, int b, char sign)
{
    //switch(sign)
    //{
    //    case '+': return a + b;
    //    case '-': return a - b;
    //    case '*': return a * b;
    //    default: return 0;
    //}

    //int result = sign switch
    //{
    //    '+' => a + b,
    //    '-' => a - b,
    //    '*' => a * b,
    //    _ => 0
    //};
    //return result;

    return sign switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        _ => 0
    };
}

enum TypeWay : byte
{
    Left = 10,
    Right,
    Forward = 50,
    Backward,
}