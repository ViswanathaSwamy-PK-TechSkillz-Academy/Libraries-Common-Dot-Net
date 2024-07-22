namespace NamesGenerator.Interfaces;

public interface IGenerateNames
{
    string[] GetNames(int nameLength = 10, int numberOfNames = 10);

    //ArrayList GetNamesArrayList(int nameLength = 10, int numberOfNames = 10);
}
