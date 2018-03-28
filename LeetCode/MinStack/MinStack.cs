using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MinStack
{
    //https://leetcode.com/problems/min-stack/description/
    public class MinStack
    {
        private List<int> _backingList;
        /** initialize your data structure here. */
        public MinStack()
        {
            _backingList = new List<int>();
        }

        public void Push(int x)
        {
            _backingList.Add(x);
        }

        public void Pop()
        {
            _backingList.RemoveAt(_backingList.Count - 1);
        }

        public int Top()
        {
            return _backingList[_backingList.Count - 1];
        }

        public int GetMin()
        {
            return _backingList.Min();
        }
    }
}
