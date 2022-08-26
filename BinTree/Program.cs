// See https://aka.ms/new-console-template for more information
using BinTrees;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Program
    {   
        static void Main(string[] args)
        {   
            BinTree<int> root = new BinTree<int>(5);
           
            for (int i = 0; i < 20; i++)
            {
                root.add(new Random().Next()%20);
            }
            //root.add(0);
            root.write_tree_1(root);
            Console.WriteLine();
            root.write_tree_2(root);
            Console.WriteLine();
            root.write_tree_3(root);
            Console.WriteLine();
            root.write_tree_4(root);
            Console.WriteLine();
            int x = 0;

            Console.WriteLine(root.find(x));

            BinTree<int>? dot_x = root.find_dot(x);
            Console.WriteLine(dot_x == null ? "null" : dot_x.get_key());
            
        }
    }
}
