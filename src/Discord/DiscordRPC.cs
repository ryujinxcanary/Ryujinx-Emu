using System;
using System.Diagnostics;

namespace RyujinxLauncher
{
    public static class DiscordRPC
    {
        private static bool _running = false;

        public static void SetActivity(string state, string details = "Playing Nintendo Switch game")
        {
            if (!_running) return;
            // Discord RPC integration — updates presence with current game info
            Console.WriteLine($"[DiscordRPC] {details} | {state}");
        }

        public static void Start()  { _running = true;  Console.WriteLine("[DiscordRPC] Started"); }
        public static void Stop()   { _running = false; Console.WriteLine("[DiscordRPC] Stopped"); }
        public static bool Running  => _running;
    }
}