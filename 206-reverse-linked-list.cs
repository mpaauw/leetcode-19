public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode previous = null;
        ListNode current = head;
        while(current != null)
        {
            var oldNext = current.next;
            current.next = previous;
            previous = current;
            current = oldNext;
        }
        return previous;
    }
}