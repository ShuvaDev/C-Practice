//// single dimensional array
//int[] a1 = [10, 20, 30];
//int[] a2 = {10, 20, 30};
//int[] a3 = new int[3];
//a3[0] = 10; a3[1] = 20; a3[2] = 20;
//int[] a4 = new int[] {10, 20, 30};

//Console.WriteLine(a4.Length); // 3
//Console.WriteLine(a4.GetLength(0)); // 3

//// multi dimensional array
//int[,] a5 = new int[,] { { 10, 20 }, { 30, 40 } };
//int[,] a6 = new int[2, 2] { { 10, 20 }, { 30, 40 } };
//a6[1, 1] = 100;

//Console.WriteLine(a5.Length); // 4
//Console.WriteLine(a5.GetLength(0)); // 2

//// 2D jagged array (arrays of array)
//int[][] jarr1 = new int[][]
//{
//    new int[] {10, 20, 30 },
//    new int[] {40, 50}
//};

//int[][] jarr2 = new int[2][];
//jarr2[0] = new int[] { 10, 20, 30 };
//jarr2[1] = new int[] { 40, 50 };

//int[][] jarr3 = new int[][]
//{
//    [10, 20, 30],
//    [40, 50]
//};

// 3D jagged array (arrays of jagged array)
int[][][] jarr4 = new int[][][]
{
    new int[][]
    {
        new int[] {10, 20},
        new int[] {30, 40, 50}

    },
    new int[][]
    {
        [60, 70, 80]
    }
};

for (int i = 0; i < jarr4.Length; i++)
{
    Console.WriteLine($"\nJagged Array : {i + 1}");
    for (int j = 0; j < jarr4[i].Length; j++)
    {
        Console.WriteLine($"Array {j + 1} of jagged array {i + 1} : ");
        for (int k = 0; k < jarr4[i][j].Length; k++)
        {
            Console.Write(jarr4[i][j][k] + " ");
        }
        Console.WriteLine();
    }
}