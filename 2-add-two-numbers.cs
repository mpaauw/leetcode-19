public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode previous = new ListNode(0);
        ListNode result = previous;
        int carry = 0;
        while (l1 != null || l2 != null || carry != 0)
        {
            ListNode current = new ListNode(0);
            int sum = ((l2 == null) ? 0 : l2.val) + ((l1 == null) ? 0 : l1.val) + carry;
            current.val = sum % 10;
            carry = sum / 10;
            previous.next = current;
            previous = current;

            l1 = (l1 == null) ? l1 : l1.next;
            l2 = (l2 == null) ? l2 : l2.next;
        }
        return result.next;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
    }
}