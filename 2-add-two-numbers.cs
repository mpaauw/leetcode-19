public ListNode AddTwoNumbers(ListNode num1, ListNode num2)
{
    ListNode temp = new ListNode(0);
    ListNode result = temp;

    int carry = 0;

    while (num1 != null || num2 != null || carry > 0)
    {
        int num1Current = (num1 != null) ? num1.Value : 0;
        int num2Current = (num2 != null) ? num2.Value : 0;

        int currentSum = num1Current + num2Current + carry;
        carry = currentSum / 10;

        ListNode currentNode = new ListNode(currentSum % 10);
        temp.Next = currentNode;
        temp = temp.Next;

        num1 = (num1 != null) ? num1.Next : num1;
        num2 = (num2 != null) ? num2.Next : num2;
    }

    return result.Next;
}

public class ListNode
{
    public ListNode(int value)
    {
        Value = value;
    }

    public int Value { get; set; }

    public ListNode Next { get; set; }
}