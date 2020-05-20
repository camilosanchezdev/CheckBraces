using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Braces
{
    class List
    {
        class Node
        {
            public char info;
            public Node next;
        }
        private Node root;
        public List()
        {
            root = null;
        }
        public void Insert(char x)
        {
            Node newElement;
            newElement = new Node();
            newElement.info = x;
            if (root == null)
            {
                newElement.next = null;
                root = newElement;
            }
            else
            {
                newElement.next = root;
                root = newElement;
            }
        }
        public char Extract()
        {
            if (root != null)
            {
                char aux = root.info;
                root = root.next;
                return aux;
            }
            else
            {
                return char.MaxValue;
            }
        }
        public bool Empty()
        {
            if (root  == null)
            {
                return true;
            }
            return false;
        }
    }
}
