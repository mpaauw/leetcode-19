
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node(){}
    public Node(int _val,IList<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
}

class Solution
{
    public Node CloneGraph(Node node)
    {
        var queue = new Queue<Node>();
        var dict = new Dictionary<Node, Node>();
        queue.Enqueue(node);

        dict.Add(node, new Node(node.val, new List<Node>()));

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            foreach (var neighbor in current.neighbors)
            {
                if (!dict.ContainsKey(neighbor))
                {
                    dict.Add(neighbor, new Node(neighbor.val, new List<Node>()));
                    queue.Enqueue(neighbor);
                }
                dict[current].neighbors.Add(dict[neighbor]);
            }
        }

        return dict[node];

    }
}
