﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sodao.FastSocket.Server;
namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            SocketServerManager.Init();
            SocketServerManager.Start();
            Console.ReadLine();
        }
    }
}
