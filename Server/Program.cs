﻿namespace Server;

internal static class Program
{
    public static void Main()
    {
        ServerObject server = new("Server.config.json");
    #if DEBUG
        Console.WriteLine("DEBUG MODE");
    #endif
        Task.WaitAny(server.ListenAsync(), server.ManageAsync());
    }
}