// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class DataScanFile
{

    static void Main(string[] args)

        // File URL link varable to store computer path
    {
        var FileUrl = @"D:\C# Activitys\Week_6_Activity_12.txt";

        try
        {
            // StreamWriter object to open a stream.

            using (StreamReader sr = new StreamReader(FileUrl))
            {

                string line;

                // int Variable to store the number of found search parameters
                int count = 0;

                { 
                    // Read every text line in file 
                    while ((line = sr.ReadLine()) != null)
                    {
                    // String array to store string data
                        string[] words = line.Split(' ');

                        //Count the frequency of each unique word.  
                        foreach (string word in words)
                        {
                            // Algorithm to search through file to find desired paramerters
                            if (word.EndsWith("t") || word.EndsWith("e")) 
                            {
                                count++;
                            }
                            
                        }
                        // Continue count for each line.
                        line = sr.ReadLine();

                    }  
                    // Display results
                    Console.WriteLine("There are " + count + " of t and e in the file.");
                    
                }
               
            }
        }

        // Fail safe if file was not found display action.
        catch (Exception ex)
        {
            Console.WriteLine("File was not read.");
        
        }

        
    } 

}
