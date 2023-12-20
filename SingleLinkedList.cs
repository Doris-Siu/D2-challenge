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

