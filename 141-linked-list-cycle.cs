public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode current = head, runner = head;
        while (current != null && runner != null)
        {
            if (null != runner.next)
            {
                runner = runner.next.next;
            }
            else
            {
                break;
            }

            if ((null != runner && null != current) && runner.Equals(current))
            {
                return true;
            }
            current = current.next;
        }
        return false;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}