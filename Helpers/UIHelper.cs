using System;
using System.Threading;

namespace DashboardMahasiswa.Helpers
{
    public static class UIHelper
    {
        public static void ShowHeader(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine($"║ {title.PadRight(42)}║");
            Console.WriteLine("╚════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void ShowWelcome()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            string[] lines = {
                "╔══════════════════════════════════════╗",
                "║    SELAMAT DATANG DI DASHBOARD!      ║",
                "╚══════════════════════════════════════╝",
            };

            foreach (var line in lines)
            {
                Console.WriteLine(line);
                Thread.Sleep(200);
            }

            Console.ResetColor();
            Thread.Sleep(600);
        }

        public static void ShowExit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n👋 Terima kasih telah menggunakan aplikasi!");
            Console.ResetColor();
            Thread.Sleep(1000);
        }

        public static void ShowError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n⚠  {msg}");
            Console.ResetColor();
        }

        public static void Pause()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nTekan ENTER untuk kembali ke menu...");
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void DrawBox(string title, string[] items)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.WriteLine($"║ {title.PadRight(50)}   ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════╣");
            Console.ResetColor();

            foreach (var item in items)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"║   {item.PadRight(48)}   ║");
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.ResetColor();
        }
    }
}