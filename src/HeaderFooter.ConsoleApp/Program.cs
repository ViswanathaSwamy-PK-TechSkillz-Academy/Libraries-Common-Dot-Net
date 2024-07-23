ForegroundColor = ConsoleColor.DarkCyan;

WriteLine("Hello, C# 12, and DotNet 8 !");

string name = typeof(Program).Namespace ?? "None!";
WriteLine($"Namespace: {name}");

ResetColor();