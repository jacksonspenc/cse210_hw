using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    //create the variable
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string fileName = "MyJournal.txt";

    
    public List<Entry>_entries;
    {

    }

    public void DisplayAll()
    {
        Console.WriteLine("\n************** Journal Entries **************");
        foreach (JournalEntry journal in _journal)
        foreach (JournalEntry journalEntry in _journal)
        {
            journal.Display();
            journalEntry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // string fileName = "MyJournal.txt";

        if (!File.Exists(fileName))
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                File.CreateText(fileName);
                outputFile.WriteLine("************** Journal Entries **************\n");
                foreach (JournalEntry journalEntry in _journal)
                {
                    outputFile.WriteLine($"{journalEntry._dateTime}");
                    outputFile.WriteLine($"Prompt: {journalEntry._journalPrompt}");
                    outputFile.WriteLine($"Entry: {journalEntry._journalEntry}\n");
                }
            }
            Console.Write("\n*** MyJournal.txt has been created! ***\n");
        }
        else
        {
            Console.Write("\n*** MyJournal.txt already exits. ***\n");
            using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
            {
                foreach (JournalEntry journalEntry in _journal)
                {
                    outputFile.WriteLine($"{journalEntry._dateTime}");
                    outputFile.WriteLine($"Prompt: {journalEntry._journalPrompt}");
                    outputFile.WriteLine($"Entry: {journalEntry._journalEntry}\n");
                }
            }
        }
    }

    public void LoadFromFile(string file)
    {

        if (File.Exists(fileName))
        {
            string text = File.ReadAllText(fileName);
            Console.WriteLine($"\n{text}");
        }
    }
}