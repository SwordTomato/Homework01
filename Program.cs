class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Input number : ");
            int numRows = int.Parse(Console.ReadLine());

            int[][] triangle = new int[numRows][];

//สามเหลี่ยม
            for(int i = 0; i < numRows; i++)
            {
                triangle[i] = new int[i + 1]; //แปลงจากinput numRows
                triangle[i][0] = 1; //เซตตัวแรกเป็น 1

                for(int j = 1; j < i; j++) //ดูแกนy
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j]; //เอาตัวจากแถวบนบวกกัน
                }

                triangle[i][i] = 1; //เซตตัวท้ายเป็น 1
            }

//ปริ้นค่า
            for(int i = 0; i < numRows; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(triangle[i][j] + " "); //แกนy
                }
                Console.WriteLine();
            }
        }
    }
