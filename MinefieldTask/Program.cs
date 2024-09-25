// See https://aka.ms/new-console-template for more information
using MinefieldTask;

//Test 1

char[,] matrix = { { '#', 'A', '#', '#' }, 
                    { 'A', '#', 'A', 'A' }, 
                    { '#', '#', '#', 'A' }, 
                    { 'A', 'A', 'A', '#' }, 
                    { '#', '#', 'A', 'A' } }; 

MineField mineField = new(5, 4, matrix);

mineField.MatricGen();
Stack<Node> nodes = mineField.FindPath(new Node(0,1));

//Console.WriteLine("------------with ally----------\n\n");
//Stack<Node> nodesWtihAlly = mineField.FindPathWithAlly(new Node(0, 1));

//Test 2

char[,] matrix1 = { { 'A', '#', 'A', '#', 'A' }, 
                    { '#', 'A', 'A', '#', '#' }, 
                    { '#', 'A', '#', 'A', 'A' }, 
                    { '#', '#', '#', 'A', 'A' }, 
                    { '#', 'A', 'A', '#', '#' }, 
                    { 'A', '#', 'A', 'A', '#' }, 
                    { '#', 'A', '#', 'A', 'A' }, 
                    { '#', '#', '#', '#', 'A' } };

MineField mineField2 = new(8, 5, matrix1);

mineField2.MatricGen();
Stack<Node> nodes2 = mineField2.FindPath(new Node(0, 0));

//Console.WriteLine("------------with ally----------\n\n");
//Stack<Node> nodesWtihAlly2 = mineField2.FindPathWithAlly(new Node(0, 0));



