using System;
using System.Collections.Generic;
using System.Text;

namespace binary_trees
{
    class tree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value > after.Data) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }
        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }
        private Node Remove(Node parent, int key)
        {
            if (parent == null) return parent;

            if (key < parent.Data) parent.LeftNode = Remove(parent.LeftNode, key);
            else if (key > parent.Data)
                parent.RightNode = Remove(parent.RightNode, key);

             
            else
            {
               
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

              
                parent.Data = MinValue(parent.RightNode);

              
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }
        private int MinValue(Node node)
        {
            int minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minv;
        }
        public void Postorder(Node node)
        {
            if (node == null)
                return;

            
            Postorder(node.LeftNode);

            Postorder(node.RightNode);
            Console.Write(node.Data + " ");
        }
        public void printInorder(Node node)
        {
            if (node == null)
                return;

            
            printInorder(node.LeftNode);

            
            Console.Write(node.Data + " ");

            
            printInorder(node.RightNode);
        }
        public void Preorder(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.Data + " ");
            Preorder(node.LeftNode);

            Preorder(node.RightNode);
            
        }
        public void Postorder() { Postorder(Root); }
        public void printInorder() { printInorder(Root); }
        public void Preorder() { Preorder(Root); }




    }

}
