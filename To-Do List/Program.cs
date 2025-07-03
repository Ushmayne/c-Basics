//A simple program for a To-Do List application
//This program is a basic template and can be expanded with more features like adding the list to a database or a file system.


using System;
using System.Collections;




public class Program
{
    public static void Main(string[] args)
    {
        ArrayList tasks = new ArrayList();
        Console.WriteLine("Welcome to the To-Do List Application!");
        previousTasks(tasks);
        DisplayMenu(tasks);


    }


    public static void previousTasks(ArrayList tasks)//will read previous tasks from a file 
    {

        
            using (System.IO.StreamReader file = new System.IO.StreamReader("tasks.txt"))
        {
            string line;
                while ((line = file.ReadLine()) != null)
                {
                    tasks.Add(line);  // Add each line back to the ArrayList
            }
        }
            
        
        
    }
    public static void newTasks(ArrayList tasks)//will write new tasks to a file
    {
        if (tasks.Count != 0)
        {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("tasks.txt"))
            {
                foreach (var item in tasks)
                {
                    file.WriteLine(item.ToString());  // Write each item in a new line
                }
            }
        }
        
    }

    public static void DisplayMenu(ArrayList tasks)
    {
        int choice;
        do
        {
            newTasks(tasks);
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add a new task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Mark task as complete");
            Console.WriteLine("4. Exit");
            choice = int.Parse(Console.ReadLine());
        } while (choice < 1 || choice > 4);

        switch (choice)
        {
            case 1:
                AddTask(tasks);
                break;
            case 2:
                ViewTasks(tasks);
                break;
            case 3:
                MarkTaskComplete(tasks);
                break;
            default:
                Console.WriteLine("Exiting the application. Goodbye!");
                break;
        }

    }

    public static void AddTask(ArrayList tasks)
    {
        Console.WriteLine("Enter the task description:");
        string taskDescription = Console.ReadLine();
        tasks.Add(taskDescription);
        Console.WriteLine("Task added successfully!");
        DisplayMenu(tasks);
    }

    public static void ViewTasks(ArrayList tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            Console.WriteLine("Your tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
        DisplayMenu(tasks);
    }
    public static void MarkTaskComplete(ArrayList tasks)
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available to mark as complete.");
            DisplayMenu(tasks);
            return;
        }
        else
        {
            Console.WriteLine("Enter the task number to mark as complete:");
            int taskNumber;
            if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task marked as complete!");
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
                MarkTaskComplete(tasks);
                return;
            }
        }
        DisplayMenu(tasks);
    }
}
