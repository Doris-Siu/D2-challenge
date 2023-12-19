using System;
namespace D2_challenge
{
	public class Node
	{
		public int element { get; set; }
		public Node next { get; set; }

		public Node(int i)
		{
			element = i;
			next = null;
		}
	}
}

