using System.IO;

namespace CSharpFileNavigation
{
    class SystemInputOutputCommands
    {
        //READ ALL RELEVANT TEXT WITHIN A FILE
        File.ReadAllText(@"Directory");

        //CREATE A NEW FILE AND ADD STRING
        File.ReadAllText(@"Directory",
            "Relevant String Input");

        //OVERWRITING FILES
        //Declare a file path as string
        string filePath = @"Directory";
        
        //Initialize a new array
        string[] newArray = { };

        //Overwrite string withing declared path with the array
        File.WriteAllLines(filePath, newArray);

        //COPYING FILES
        //Takes two labelled paths and copies one file to another with a new name
        string pathOne = @"Directory/FileOne";
        string pathTwo = @"Directory/FileTwo";
        File.Copy(pathOne, pathTwo, true);

        //CREATING DIRECTORIES AND FILES
        Directory.CreateDirectory(@"Directory");
        File.Create(@"Directory/NewFile");
    }
}
