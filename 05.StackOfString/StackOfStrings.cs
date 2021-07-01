using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        private Stack<string> myStack;

        public StackOfStrings()
            : base()
        {
            myStack = new Stack<string>();
        }
        public bool IsEmpty()
        => myStack.Any();

        public void AddRange(Stack<string> collection)
        {
            foreach (var item in collection)
            {
                base.Push(item);
            }
        }
    }
}
