using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public TreeNode Root;

        public BinaryTree()
        {
            Root = null;
        }

        // Рекурсивная функция для обхода бинарного дерева в глубину 
        public void PreOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " "); // Посещаем текущий узел.
                PreOrderTraversal(node.Left);    // Рекурсивно обходим левое поддерево.
                PreOrderTraversal(node.Right);   // Рекурсивно обходим правое поддерево.
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Создаем бинарное дерево.
            BinaryTree tree = new BinaryTree();
            tree.Root = new TreeNode(1);
            tree.Root.Left = new TreeNode(2);
            tree.Root.Right = new TreeNode(3);
            tree.Root.Left.Left = new TreeNode(4);
            tree.Root.Left.Right = new TreeNode(5);

            // Вызываем обход дерева в глубину  с корня.
            Console.WriteLine("Результат обхода дерева в глубину :");
            tree.PreOrderTraversal(tree.Root);
        }
    }
}
