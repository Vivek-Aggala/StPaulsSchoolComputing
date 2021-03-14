using System;
using System.Collections;
namespace reverse_polish
{
    public class Node
    {

        public char value;
        public Node left, right;

        public Node(char item)
        {
            value = item;
            left = right = null;
        }
    }

    class ExpressionTree
    {

        
        Boolean isOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*'
                || c == '/' || c == '^')
            {
                return true;
            }
            return false;
        }

        
        void inorder(Node t)
        {
            if (t != null)
            {
                inorder(t.left);
                Console.Write(t.value + " ");
                inorder(t.right);
            }
        }

        
        Node constructTree(char[] postfix)
        {
            Stack stack1 = new Stack();
            Node t, t1, t2;

            
            for (int i = 0; i < postfix.Length; i++)
            {

                
                if (!isOperator(postfix[i]))
                {
                    t = new Node(postfix[i]);
                    stack1.Push(t);
                }
                else
                {
                    t = new Node(postfix[i]);

                    
                    t1 = (Node)stack1.Pop();    
                    t2 = (Node)stack1.Pop();

                    
                    t.right = t1;
                    t.left = t2;

                    
                    stack1.Push(t);
                }
            }

            
            t = (Node)stack1.Peek();
            stack1.Pop();

            return t;
        }

        
        public static void Main(String[] args)
        {
            ExpressionTree et = new ExpressionTree();
            String postfix = "ab+ef*g*-";
            char[] charArray = postfix.ToCharArray();
            Node root = et.constructTree(charArray);
            Console.WriteLine("infix expression is");
            et.inorder(root);
        }
    }
}
