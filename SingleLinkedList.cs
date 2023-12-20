using System;
namespace D2_challenge
{
	public class SingleLinkedList
	{
		private Node _start;

		public SingleLinkedList()
		{
			_start = null;
		}

        // node insertion
        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.next = _start;
            _start = temp;

        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);


        if (_start == null)
            {
                _start = temp;
                return;
            };

            p = _start;
            while (p.next != null)
            {
                p = p.next; //traverse & reference the last node

            }

            p.next = temp;
        }

        public void InsertAfter(int data, int x)

        {
            if (_start == null)
            {
                Console.WriteLine("Empty List.");
                return;
            }

            Node p = _start;

            while (p!=null)
            {
                if (p.element==x)
                {
                    break;
                }

                p = p.next;

            }

            if (p==null)
            {
                Console.WriteLine(x + " is not presented in the list");
            }
            else
            {
                Node temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node temp;

            if (_start==null)
            {
                Console.WriteLine("Empty List.");
                return;
            }
            if (x==_start.element) //x is the 1st node
            {
                temp = new Node(data);
                temp.next = _start;
                _start = temp;
                return;
            }

            //find predecessor of x
            Node p = _start;
            while (p.next!=null)
            {
                if (p.next.element == x)
                {
                    break;
                }
                p = p.next;

            }

            if (p.next == null)
            {
                Console.WriteLine(x + " is not presented in the list");
            }
            else
            {
                temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
            }
        }

        public void InsertAtPosition(int data, int k)
        {
            Node temp;
            int i;

            if (k==1)
            {
                temp = new Node(data);
                temp.next = _start;
                _start = temp;
                return;
            }

            Node p = _start;
            for ( i = 1; i < k-1 && p!=null; i++)
            {
                p = p.next;

            }

            if (p==null)
            {
                Console.WriteLine("You can only insert up to " + i + "th position");
            }
            else
            {
                temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
            }


        }

        // node deletion
        public void DeleteFirstNode()
        {
            if (_start==null)
            {
                return;
            }

            if (_start.next == null) // the only node
            {
                _start = null;
                return;
            }

            _start = _start.next;
        }

        public void DeleteLastNode()
        {
            if (_start == null)
            {
                return;
            }

            if (_start.next==null) // the only node
            {
                _start = null;
                return;
            }

            Node p = _start;
            while (p.next.next!=null)
            {
                p = p.next;
            }

            p.next = null;

        }

        public void DeleteNode(int x)
        {
            if (_start == null)
            {
                return;
            }

            if (_start.element==x)
            {
                _start = _start.next;
                return;
            }

            Node p = _start;
            while (p.next!=null)
            {
                if (p.next.element==x)
                {
                    break;
                }
                p = p.next;
        
            }

            if (p.next==null)
            {
                Console.WriteLine("Element " + x + " not in the list");

            }
            else
            {
                p.next = p.next.next;
            }

        }


        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the element to be inserted : ");

                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }



        public void DisplayList()
		{
            Node p;
            if (_start ==null)
            {
                Console.WriteLine("Empty list.");
                return;
            }
            Console.WriteLine("List is : " );

            p = _start;
            while (p!=null)
            {
                Console.Write(p.element+" ");
                p = p.next;
            }

		}

        public void CountNodes()
		{
            int counter = 0;
            Node p = _start;

            while (p!=null)
            {
                counter++;
                p = p.next;
            }

            Console.WriteLine("Number of nodes in the list is " + counter);
        }

        public bool Search (int x)
        {
            int position = 1;
            Node p = _start;

            while (p!=null)
            {
                if (p.element==x)
                {
                    break;

                }

                position++;
                p = p.next;
            }

            if (p==null)
            {
                Console.WriteLine(x + " is not found in list");
                return false;
                
            }
            else
            {
                Console.WriteLine(x+" is at position " + position);
                return true;
            }
        }


    }
}

