﻿using System;
using System.Collections.Generic;

class MyStack {
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search) {

        if (aStack == null || aStack.Count == 0) {
            Console.WriteLine("Stack is Empty");
            return aStack;
        }

        Stack<string> tempStack = new Stack<string>(aStack);

        Console.WriteLine("Number of items: {0}", aStack.Count);
        Console.WriteLine("Top Item: {0}", aStack.Peek());

        bool tf = aStack.Contains(search);
        Console.WriteLine("Stack contains {0}: {1}", search, tf);

        if (tf) {
            while (aStack.Pop() != search) {
            }
        }

        aStack.Push(newItem);

        return aStack;
    }
}