﻿using System;
using Interfaces;
using Storage;


namespace FileManager
{
    public class HelpTrigger : ITrigger<Context>
    {
        public bool Condition(Context arguments)
        {
            return (arguments.Args[0].ToLower() == "help");
        }

        public void Action(Context arguments)
        {
            Console.WriteLine("Use this program to manage links in your links repository. For close just press CTRL+C.\n\n " +
                "Avalible commands:\n" +
                "1. Delete [addres]\n" +
                "2. Create [addres] [path to file]\n" +
                "3. Help\n" +
                "4. Print\n" +
                "5. Show [addres]");
        }
    }
}