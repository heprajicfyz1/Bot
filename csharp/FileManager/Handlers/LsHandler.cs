﻿using System;

namespace FileManager
{
    public class LsHandler : IInputHandler
    {
        public string Trigger => "ls";

        public bool Run(string[] args, Manager fileManager)
        {
            Console.WriteLine(fileManager.GetAllLinks());
            return true;
        }
    }
}