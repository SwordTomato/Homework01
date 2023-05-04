class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Input number : ");
            int numRows = int.Parse(Console.ReadLine());

            if(numRows >= 0) {

            int[][] triangle = new int[numRows][];

            for(int i = 0; i < numRows; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;

                for(int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }

                triangle[i][i] = 1;
            }

            for(int i = 0; i < numRows; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        } Console.WriteLine("Invalid Pascal’s triangle row number.");
    }
    }
