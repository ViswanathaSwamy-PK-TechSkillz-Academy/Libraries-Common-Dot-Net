namespace ConsoleColorStyleLib;

public static class ConsoleColorStyleHelper
{
    public static ConsoleColor GetConsoleForegroundColor(ConsoleColorStyle style) => style switch
    {
        ConsoleColorStyle.DarkYellow => ConsoleColor.DarkYellow,

        ConsoleColorStyle.DarkCyan => ConsoleColor.DarkCyan,

        ConsoleColorStyle.DarkGreen => ConsoleColor.DarkGreen,

        ConsoleColorStyle.DarkMagenta => ConsoleColor.DarkMagenta,

        ConsoleColorStyle.Red => ConsoleColor.Red,

        _ => ConsoleColor.White
    };

}
