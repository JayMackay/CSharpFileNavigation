using System;
using System.IO;

namespace CSharpFileNavigation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read all text within a file
            string lyrics = File.ReadAllText(
                @"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Lyrics\Random Lyrics.txt");
            Console.WriteLine(lyrics);

            //Create a new file and add a string to it
            File.WriteAllText(
                @"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Lyrics\New Song.txt",
                "Testing New Song");

            //Overwriting New Song File
            //Overwrites the string in filePath with an array
            string filePath = @"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Lyrics\New Song.txt";
            string[] lyricsArray = { "Bars", "Cars", "Mars" };  //Initialize array
            File.WriteAllLines(filePath, lyricsArray);
            foreach (string i in lyricsArray)
            {
                Console.WriteLine(i);
            }

            //Copying text from one file to the next
            string pathOne = @"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Lyrics\Old Lyrics.txt";
            string pathTwo = @"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Lyrics\New Lyrics.txt";
            File.Copy(pathOne, pathTwo, true);
            //Takes two labelled paths and copies one file to another with a new name

            //Return Create & Write Times Of Specified Files
            //Creation Time defines the initial DateTime the file was created
            //Write Time defines the recent DateTime that the file was changed or edited
            DateTime lastWriteTime = File.GetLastWriteTime(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Lyrics\Old Lyrics.txt");
            DateTime creationTime = File.GetCreationTime(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Lyrics\Old Lyrics.txt");
            Console.WriteLine($"{lastWriteTime}");
            Console.WriteLine($"{creationTime}");

            //Display the directory information of an initialized variable
            var fileInformation = new FileInfo(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Lyrics\Old Lyrics.txt");
            Console.WriteLine(fileInformation.DirectoryName);

            //Create & Delete Directory
            Directory.CreateDirectory(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Example Folder");
            Directory.Delete(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Example Folder");

            //Create New Directory & Populate With Files 
            Directory.CreateDirectory(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Example Folder");
            File.Create(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Example Folder\ExampleTextOne.txt");
            File.Create(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Example Folder\ExampleTextTwo.txt");
            File.Create(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Example Folder\ExampleTextThree.txt");


            File.WriteAllText(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Example Folder\ExampleTextOne.txt",
                "Initialize test string");
            var fileInfo = new FileInfo(@"C:\Users\TECH-W141birm\Desktop\StreamingAndSerialisation\Example Folder\ExampleTextOne.txt");
            Console.WriteLine(fileInfo.DirectoryName);
        }
    }
}
