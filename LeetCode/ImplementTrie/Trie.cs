using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ImplementTrie
{
    public class Trie
    {
        public Trie[] Nodes { get; set; }
        public bool IsWord { get; set; }

        /** Initialize your data structure here. */
        public Trie()
        {
            Nodes = new Trie[26];
            IsWord = false;
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            var currentNode = this;
            for (int i = 0, n = word.Length; i < n; i++)
            {
                var characterValue = word[i] - 97;
                if (currentNode.Nodes[characterValue] == null)
                {
                    currentNode.Nodes[characterValue] = new Trie();
                }
                currentNode = currentNode.Nodes[characterValue];
            }
            currentNode.IsWord = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            var currentNode = this;
            for (int i = 0, n = word.Length; i < n; i++)
            {
                var characterValue = word[i] - 97;
                if (currentNode.Nodes[characterValue] == null)
                {
                    return false;
                }
                currentNode = currentNode.Nodes[characterValue];
            }
            if (currentNode.IsWord)
            {
                return true;
            }
            return false;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            var currentNode = this;
            for (int i = 0, n = prefix.Length; i < n; i++)
            {
                var characterValue = prefix[i] - 97;
                if (currentNode.Nodes[characterValue] == null)
                {
                    return false;
                }
                currentNode = currentNode.Nodes[characterValue];
            }
            return true;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
