using System;

namespace Gamelife
{
    class Program
    {
        //Intiliazing Generation count
        public static int Generation = 1;
        public static void Main()
        {
            int M = 25, N = 25;
            int input = 0;
            // Intiliazing the grid.
            int[,] grid = {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }

        };

            // Displaying the grid
            Console.WriteLine("Zero Generation");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (grid[i, j] == 0)
                        Console.Write(".");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Getting Which Geneartion need living population position
            Console.WriteLine("Which generations's population positions are you interested in? ");
            input= Convert.ToInt32 (Console.ReadLine().ToString());
            nextGeneration(grid, M, N, input);
        }

        // Function to print next generation
        static void nextGeneration(int[,] grid,
                                   int M, int N, int inp)
        {
            int[,] future = new int[M, N];
            string Output=null, position=null;
            

            // Loop through every cell

            for (int l = 1; l < M - 1; l++)
            {
                for (int m = 1; m < N - 1; m++)
                {

                    // finding no Of Neighbours
                    // that are alive
                    int aliveNeighbours = 0;
                    for (int i = -1; i <= 1; i++)
                        for (int j = -1; j <= 1; j++)
                            aliveNeighbours +=
                                    grid[l + i, m + j];

                    // The cell needs to be subtracted
                    // from its neighbours as it was
                    // counted before
                    aliveNeighbours -= grid[l, m];

                    // Implementing the Rules of Life

                    // Cell is lonely and dies
                    if ((grid[l, m] == 1) &&
                                (aliveNeighbours < 2))
                        future[l, m] = 0;

                    // Cell dies due to over population
                    else if ((grid[l, m] == 1) &&
                                 (aliveNeighbours > 3))
                        future[l, m] = 0;

                    // A new cell is born
                    else if ((grid[l, m] == 0) &&
                                (aliveNeighbours == 3))
                        future[l, m] = 1;

                    // Remains the same
                    else
                        future[l, m] = grid[l, m];
                }
            }
            Console.WriteLine("Generation : " + Generation.ToString());
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    position = null;
                    if (future[i, j] == 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                        position = "(" + i.ToString() + "," + j.ToString() + ")";
                    }
                    if (!string.IsNullOrWhiteSpace(position))
                    {
                        Output = string.IsNullOrWhiteSpace(Output) ? position : Output + "," + position;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (Generation != inp)
            {
                Generation++;
                nextGeneration(future, M, N, inp);
            }
            else
            {
                Console.WriteLine("List of positions of living population for Generation " + Generation.ToString() + " is: ");                         
                Console.WriteLine();
                Console.WriteLine("[" + Output + "]");
                Console.WriteLine();
            }
        }
    }
}
