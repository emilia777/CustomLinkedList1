using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CustomLinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class CustomLinkedList
    {
        Node _head;
        public Node First => _head;
        public Node Last
        {
            get { return GetBeforeNode(); }

        }
        int _count;
        public int Count
        {
            get
            {
                if (_count < 0)
                {
                    _count = 0;
                }
                return _count;
            }
            private set
            { _count = value; }
        }
        public Node GetBeforeNode()
        {
            Node tmp = _head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
            }
            return tmp;
        }
        public void AddAfter(Node node)
        {
            Node Newnode = new Node(node.Data);
            Count++;
            if (_head != null)
            {
                Newnode.Next = _head;
            }
            _head = Newnode;

        }
        public void AddBefore(Node node)

        {
            Node newNode = new Node(node.Data);
            Count++;
            if (_head == null)
            {
                _head = newNode;
                return;
            }
            Node beforeNode = GetBeforeNode();
        }
        public void Print()
        {

            Node tmp =new Node(0);
            while(_head.Next != null)
            {
                Console.WriteLine(tmp.Data);
                tmp = tmp.Next;
            }
        }
    }
}