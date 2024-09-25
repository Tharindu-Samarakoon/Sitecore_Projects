using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinefieldTask
{
    internal class MineField
    {
        //No of rows in the matrix
        int r;
        //No of columns in the matrix
        int c;
        //The matrix with bombs and path
        char[,] matrix;

        public MineField()
        {

        }

        public MineField(int noOfRows, int noOfCols, char[,] matrix)
        {
            this.r = noOfRows;
            this.c = noOfCols;
            this.matrix = matrix;
        }

        /* 
         Method for printing out the matrix
         */
        public void MatricGen()
        {

            for (int i = 0; i < r; i++)
            {
                for (int y = 0; y < c; y++)
                {
                    Console.Write(matrix[i, y] + "  ");
                }
                Console.WriteLine();
            }
        }

        /* 
         Method to get the valid neighbors of a node.
         */
        public List<Node> GetNeighbors(Node n)
        {
            List<Node> newNeighbors = new();
            int neighbors = 8;
            //How the x and y values can change to identify neighbors.
            //N, R, S, W, NW, NE, SE, SW
            //These determine the order the nodes are added to the stack as well
            int[] x = [-1, -1, 1, 1, 0, 0, -1, 1];
            int[] y = [-1, 1, -1, 1, -1, 1, 0, 0];
            Console.WriteLine("Neighbors are : " );

            //Iterate through the 2 arrays and obtain the possible neighbors
            for(int i = 0; i < neighbors; i++)
            {
                int nr = n.r + x[i];
                int nc = n.c + y[i];

                //Check if the neighbors are within the matrix boundary
                if (nr >= r || nc >= c || nr < 0 || nc < 0) continue;
                //Check if the neighbor is a bomb
                if (matrix[nr, nc] == '#') continue;
                Console.WriteLine(nr + "," + nc);

                newNeighbors.Add(new Node(nr, nc));
            }

            return newNeighbors;
        }

        /* 
         Method to guide sniffy through the minefield.
         */
        public Stack<Node> FindPath(Node start)
        {
            //2D array to keep track of visited nodes.
            bool[,] visited = new bool[r, c];
            //Stack to keep track of nodes in the path
            Stack<Node> stack = new();

            stack.Push(start);
            

            while(stack.Count > 0)
            {
                Node v = stack.Pop();
                Console.WriteLine("Going to : " + v.r + " , " + v.c);
                //If sniffy is already in the bottom most row. He has crossed the minefield safely.
                if (v.r == r - 1)
                {
                    Console.WriteLine("Sniffy found a path!! ヽ(°ᴥ°)ﾉ ");
                    return stack;
                }
                //Check if the node is already visited or not.
                if (visited[v.r, v.c] != true)
                {
                    visited[v.r, v.c] = true;
                    //Get neighbors of that neighbor and add them to the stack if not visited already.
                    foreach(Node n in GetNeighbors(v))
                    {
                        if (visited[n.r, n.c] != true) stack.Push(n);
                    }
                }
            }

            Console.WriteLine("No path found. Sniffy is Sad.");
            return null;

        }

        //Difficulty 2 - Ally with Dog (Incomplete)
        public Stack<Node> FindPathWithAlly(Node start)
        {
            bool[,] visited = new bool[r, c];
            Node ally = new();
            Node prev = start;
            Stack<Node> stack = new();

            stack.Push(start);


            while (stack.Count > 0)
            {
                
                if(stack.Peek() == ally)
                {
                    Console.WriteLine("Oh no! Ally and Sniffy cannot be in the same square");
                    return null;
                }
                
                Node v = stack.Pop();
                Console.WriteLine("Going to : " + v.r + " , " + v.c);
                if (prev != v)
                {
                    ally = prev;
                    Console.WriteLine("Ally moved to : " + ally.r + " , " + ally.c);
                }

                if (v.r == r - 1)
                {
                    Console.WriteLine("Sniffy found a path!! ヽ(°ᴥ°)ﾉ ");
                    return stack;
                }
                if (visited[v.r, v.c] != true)
                {
                    visited[v.r, v.c] = true;
                    foreach (Node n in GetNeighbors(v))
                    {
                        if (visited[n.r, n.c] != true) stack.Push(n);
                    }
                }
                prev = v;
            }

            Console.WriteLine("No path found. Sniffy is Sad.");
            return null;

        }

    }
}
