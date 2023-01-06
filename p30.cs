// Jagged Arrays
int[][] jArray1 = new int[2][]; // can include two single-dimensional arrays
int[][,] jArray2 = new int[3][,]; // can include three two-dimensional arrays

// Jagged Array
int[][] jArray = new int[2][];

jArray[0] = new int[3] { 1, 2, 3 };

jArray[1] = new int[4] { 4, 5, 6, 7 };

// Jagged Array
int[][] jArray = new int[2][] { new int[3] { 1, 2, 3 }, new int[4] { 4, 5, 6, 7 } };

jArray[0][0]; //returns 1
jArray[0][1]; //returns 2
jArray[0][2]; //returns 3
jArray[1][0]; //returns 4
jArray[1][1]; //returns 5
jArray[1][2]; //returns 6
jArray[1][3]; //returns 7

// Jagged Array
int[][] jArray = new int[2][] { new int[3] { 1, 2, 3 }, new int[4] { 4, 5, 6, 7 } };

for (int i = 0; i < jArray.Length; i++)
{
    for (int j = 0; j < (jArray[i]).Length; j++)
        Console.WriteLine(jArray[i][j]);
}

// Jagged Array
int[][,] jArray = new int[2][,];

jArray[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
jArray[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };

jArray[0][1, 1]; //returns 4

jArray[1][1, 0]; //returns 9

jArray[1][1, 1]; //returns 10

// Jagged Array
int[][][] intJaggedArray = new int[2][][]
{
    new int[2][] { new int[3] { 1, 2, 3 }, new int[2] { 4, 5 } },
    new int[1][] { new int[3] { 7, 8, 9 } }
};

Console.WriteLine(intJaggedArray[0][0][0]); // 1

Console.WriteLine(intJaggedArray[0][1][1]); // 5

Console.WriteLine(intJaggedArray[1][0][2]); // 9
