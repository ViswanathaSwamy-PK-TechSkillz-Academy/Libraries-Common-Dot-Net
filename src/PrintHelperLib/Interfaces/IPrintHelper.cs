using System.Collections;

namespace PrintHelperLib.Interfaces;

public interface IPrintHelper
{
    void Print(string[] names);

    void Print(ArrayList names);
}