using System;
using System.Collections.Generic;

class MyStack {
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search) {


        Stack<string> tempStack = new Stack<string>(aStack);

        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (aStack == null || aStack.Count == 0) {
            Console.WriteLine("Stack is empty");
        }
        else {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }

        bool tf = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, tf);

        if (tf) {
            while (aStack.Pop() != search) {}
        }

        aStack.Push(newItem);

        return aStack;
    }
}