using System;
namespace D2_challenge
{
	public class NodeReferencing
	{
        private Node _start;

        public NodeReferencing()
		{
			_start = null;
		}

		public void FindLastNode()
		{
			Node p = _start;

			while (p.next !=null)
			{
				p = p.next;
			}
		}

        public void FindSecondLastNode()
        {
            Node p = _start;

            while (p.next.next != null)
            {
                p = p.next;
            }
        }

        public void FindSpecificEle(int x)
        {
            Node p = _start;

            while (p != null)
            {
                if (p.element == x)
                {
                    break;
                }
                p = p.next;
            }
        }

        public void FindPredecessorOfNode(int x)
        {
            Node p = _start;

            while (p.next != null)
            {
                if (p.next.element == x)
                {
                    break;
                }
                p = p.next;
            }

        }

        public void FindNodeAtPosition(int k)
        {
            Node p = _start;

            for (int i = 1; i < k; i++)
            {
                p = p.next;
            }
        }
    }
}

