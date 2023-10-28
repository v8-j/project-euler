// By starting at the top of the triangle below and moving to adjacent numbers 
// on the row below, the maximum total from top to bottom is 23.
//    3
//   7 4
//  2 4 6
// 8 5 9 3
// That is, 3 + 7 + 4 + 9 = 23.
// Find the maximum total from top to bottom of the triangle below:


//               75                                
//              95 64
//             17 47 82
//            18 35 87 10
//           20 04 82 47 65
//          19 01 23 75 03 34
//         88 02 77 73 07 63 67
//        99 65 04 28 06 16 70 92
//       41 41 26 56 83 40 80 70 33
//      41 48 72 33 47 32 37 16 94 29
//     53 71 44 65 25 43 91 52 97 51 14
//    70 11 33 28 77 73 17 78 39 68 17 57
//   91 71 52 38 17 14 91 43 58 50 27 29 48
//  63 66 04 68 89 53 67 30 73 16 69 87 40 31
// 04 62 98 27 23 09 70 98 73 93 38 53 60 04 23

// NOTE: As there are only 16384 routes, it is possible to solve this problem by
// trying every route. However, Problem 67 is the same challenge with a triangle
// containing one-hundred rows; it cannot be solved by brute force, and requires
// a clever method! ;o)

//              Indices
//                01
//               02 03
//              04 05 06
//             07 08 09 10
//            11 12 13 14 15
//           16 17 18 19 20 21


// I'm stupid, nevertheless i realise this is going to require recursion, 
// my nemises. Along with all my other nemeses.

// Originally wrote this to take products, because i didnt read the question 
// properly, hence BigIntegers...

using System.Numerics;

class Maximum_Path_Sum_I
{
    public static void Run()
    {
        // stick the data in a 2d array
        int[][] nums2d = new int[15][];
        int index = -1;
        for (int i = 0; i < 15; ++i)
        {
            nums2d[i] = new int[i + 1];
            for (int j = 0; j < i + 1; ++j)
            {
                nums2d[i][j] = nums[++index];
            }
        }

        BigInteger maxSum = WorkTreeSum(14, nums2d, 0,0);
        BigInteger maxProduct = WorkTreeProduct(14, nums2d, 0,0);

        Console.WriteLine($"The maximum sum is {maxSum}");
        Console.WriteLine($"The maximum product is {maxProduct}");        
    }

        static BigInteger WorkTreeSum(int maxDepth, int[][] nums, int i, int j)
    {   
        // we've reached the bottom of the tree, return i,j
        if (i == maxDepth) {
            return nums[i][j];
        }

        // recurse down to next i, where j = current and j = current + 1
        // It will bring back which ever product is bigger, and multiply it by
        // the value in the current cell
        return nums[i][j] + BigInteger.Max(WorkTreeSum(maxDepth, nums, i+1, j), WorkTreeSum(maxDepth, nums, i+1, j+1));        
    }

    static BigInteger WorkTreeProduct(int maxDepth, int[][] nums, int i, int j)
    {   
        // we've reached the bottom of the tree, return i,j
        if (i == maxDepth) {
            return nums[i][j];
        }

        // recurse down to next i, where j = current and j = current + 1
        // It will bring back which ever product is bigger, and multiply it by
        // the value in the current cell
        return nums[i][j] * BigInteger.Max(WorkTreeProduct(maxDepth, nums, i+1, j), WorkTreeProduct(maxDepth, nums, i+1, j+1));        
    }

    static int[] nums =
    {
        75,
        95, 64,
        17, 47, 82,
        18, 35, 87, 10,
        20, 04, 82, 47, 65,
        19, 01, 23, 75, 03, 34,
        88, 02, 77, 73, 07, 63, 67,
        99, 65, 04, 28, 06, 16, 70, 92,
        41, 41, 26, 56, 83, 40, 80, 70, 33,
        41, 48, 72, 33, 47, 32, 37, 16, 94, 29,
        53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14,
        70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57,
        91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48,
        63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31,
        04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23
    };
}