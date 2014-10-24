using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeEnumerator
{
    class TreeNode
    {
        public int Depth = 0;
        public string Text = "";
        public List<TreeNode> Children = new List<TreeNode>();
        public TreeNode(string text)
        {
            Text = text;
        }

        // Add and create children.
        public TreeNode AddChild(string text)
        {
            TreeNode child = new TreeNode(text);
            child.Depth = Depth + 1;
            Children.Add(child);
            return child;
        }

        // Return the tree's nodes in an preorder traversal.
        public List<TreeNode> Preorder()
        {
            // Make the result list.
            List<TreeNode> nodes = new List<TreeNode>();

            // Traverse this node's subtree.
            TraversePreorder(nodes);

            // Return the result.
            return nodes;
        }
        private void TraversePreorder(List<TreeNode> nodes)
        {
            // Traverse this node.
            nodes.Add(this);

            // Traverse the children.
            foreach (TreeNode child in Children)
                child.TraversePreorder(nodes);
        }

        // Return an enumerator.
        public IEnumerable<TreeNode> GetTraversal()
        {
            // Get the preorder traversal.
            List<TreeNode> traversal = Preorder();

            // Yield the nodes in the traversal.
            foreach (TreeNode node in traversal) yield return node;
            yield break;
        }
    }
}
