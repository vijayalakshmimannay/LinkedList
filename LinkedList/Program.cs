﻿// See https://aka.ms/new-console-template for more information

using System;
namespace LinkedList
{
    internal class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedListData list = new LinkedListData();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.DisPlay();

        }
    }
}