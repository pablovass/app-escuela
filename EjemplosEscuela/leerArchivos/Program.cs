using System;
using System.IO;

namespace leerArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            
try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader("C:\\captions.srt");
    //Read the first line of text
    line = sr.ReadLine();
    //Continue to read until you reach end of file
    while (line != null)
    {
       
        
        if(line == ){

        }
        //write the lie to console window
        Console.WriteLine(line);
        //Read the next line
        line = sr.ReadLine();
       
    }
    //close the file
    sr.Close();
    Console.ReadLine();
}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}
        }
    }
}
