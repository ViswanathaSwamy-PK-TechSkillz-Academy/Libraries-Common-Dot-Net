using HeaderFooter;

Header _header = new();
Footer _footer = new();

_header.DisplayHeader('=', "C# 12, and DotNet 8");

ForegroundColor = ConsoleColor.DarkCyan;

WriteLine("Hello, C# 12, and DotNet 8 !");

string name = typeof(Program).Namespace ?? "None!";
WriteLine($"Namespace: {name}");

ResetColor();

_footer.DisplayFooter('-');