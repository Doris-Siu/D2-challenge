using System;
namespace D2_challenge
{

	// defintion of singly-linked list
	public class ListNode
	{
		public int val { get; set; }
		public ListNode next { get; set; }

		public ListNode(int val=0, ListNode next=null)
		{
			this.val = val;
			this.next = next;
		}


		public  static ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			if (l1 is null)
				return l2;

			if (l2 is null)
			{
				return l1;
			}

			if (l1.val>l2.val)
			{
				l2.next = MergeTwoLists(l1, l2.next);
				return l2;
			}
			else
			{
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }

		}
	}
}

