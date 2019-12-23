using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_life
{
    public class Program
    {
        /*
            1.  Any live cell with fewer than two live neighbours dies, as if by underpopulation.
            2.  Any live cell with two or three live neighbours lives on to the next generation.
            3.  Any live cell with more than three live neighbours dies, as if by overpopulation.
            4.  Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
        */

        public static void Main(string[] args)
        {
            //System.Console.WriteLine(DateTime.Now.Ticks);
            //System.Console.ReadLine();

            //Random generator = new Random(Convert.ToInt32(DateTime.Now.Ticks/1000000));
            Random generator = new Random();
            int randomNumber = 0;
            string displayChar = " ";


            //  create and initialize the 2D array
            int[,] cells = new int[10,10];
            int[,] neighbors = new int[10,10];

            for (int row = 0; row < 10; row++)
            {
               for (int col = 0; col < 10; col++)
                {
                    randomNumber = generator.Next(100);
                    cells[row,col] = 0;
                    if (randomNumber > 65)
                    {
                        cells[row,col] = 1;
                    }
                    //cells[row][col] = row + col;
                }
            }
            
            // initialize the neighbor count array
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    neighbors[row, col] = 0;
                }
            }
            

            do
            {
                System.Console.WriteLine("\n--------------------------------");

                //  display the 2D array
                //string displayChar = "";
                displayChar = " ";
                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        displayChar = " ";
                        if (cells[row,col] == 1)
                        {
                            displayChar = "O";
                        }
                        System.Console.Write(displayChar);
                        //System.Console.Write(displayChar + " ");
                        //System.Console.Write(cells[row][col] + " ");
                    }
                    System.Console.WriteLine();
                }



                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        neighbors[row,col] = 0;
                    }
                }

                // count neighbors
                //  count each cell's neighbors
                int rowPosn = 0;
                int colPosn = 0;
                int neighborCount = 0;

                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        neighborCount = 0;
                        for (int rowDelta = -1; rowDelta <= 1; rowDelta++)
                        {
                            for (int colDelta = -1; colDelta <= 1; colDelta++)
                            {
                                rowPosn = row + rowDelta;
                                colPosn = col + colDelta;
                                if (rowPosn < 0 || rowPosn > 9 || colPosn < 0 || colPosn > 9)
                                {
                                    //  outside the boundaries  skip/ignore
                                }
                                else
                                {
                                    if ((rowPosn == row) && (colPosn == col))
                                    {
                                        // cell is itself ...  skip
                                    }
                                    else
                                    {
                                        if (cells[rowPosn,colPosn] == 1)
                                        {
                                            neighborCount++;
                                        }
                                    }

                                    /*
                                    if (rowPosn != row || colPosn != col)
                                    {
                                        if (cells[rowPosn][colPosn] == 1)
                                        {
                                            neighborCount++;
                                        }
                                    }
                                    */
                                }
                            }
                        }
                        neighbors[row,col] = neighborCount;
                    }
                }

                /*
                System.Console.WriteLine("\n--------------------------------");
                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        System.Console.Write(neighbors[row,col]);
                    }
                    System.Console.WriteLine();
                }
                */


                //  determine/set the next generation
                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        if (cells[row,col] == 1)
                        {
                            // if cell is alive....
                            switch (neighbors[row,col])
                            {
                                case 0:
                                    cells[row,col] = 0;
                                    break;
                                case 1:
                                    cells[row,col] = 0;
                                    break;
                                case 2:
                                    cells[row,col] = 1;
                                    break;
                                case 3:
                                    cells[row,col] = 1;
                                    break;
                                case 4:
                                    cells[row,col] = 0;
                                    break;
                                case 5:
                                    cells[row,col] = 0;
                                    break;
                                case 6:
                                    cells[row,col] = 0;
                                    break;
                                case 7:
                                    cells[row,col] = 0;
                                    break;
                                case 8:
                                    cells[row,col] = 0;
                                    break;
                            }
                        }
                        else
                        {
                            //  if cell is dead ....
                            switch (neighbors[row,col])
                            {
                                case 0:
                                    cells[row,col] = 0;
                                    break;
                                case 1:
                                    cells[row,col] = 0;
                                    break;
                                case 2:
                                    cells[row,col] = 0;
                                    break;
                                case 3:
                                    cells[row,col] = 1;
                                    break;
                                case 4:
                                    cells[row,col] = 0;
                                    break;
                                case 5:
                                    cells[row,col] = 0;
                                    break;
                                case 6:
                                    cells[row,col] = 0;
                                    break;
                                case 7:
                                    cells[row,col] = 0;
                                    break;
                                case 8:
                                    cells[row,col] = 0;
                                    break;
                            }

                        }
                    }
                }



                System.Console.ReadLine();
            } while (true);



            System.Console.ReadLine();

        }
    }
}
