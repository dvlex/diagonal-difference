// See https://aka.ms/new-console-template for more information


List<List<int>> matrix = [[1,2,3],[4,5,6],[9,8,9]];

System.Console.WriteLine(Result.diagonalDifference(matrix));
// System.Console.WriteLine(matrix[0].Count());

// foreach (var row in matrix)
// {
//     foreach (var item in row)
//     {
//         Console.WriteLine(item);
//     }
// }


class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int result = 0;
        int length = arr[0].Count();
        for (int i = 0; i < length; i++)
        {
            result += arr[i][i];
            result -= arr[i][length - 1 - i];
        }
        return Math.Abs(result);
    }

}