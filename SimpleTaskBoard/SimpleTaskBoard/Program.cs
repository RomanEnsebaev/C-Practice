using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Performer worker1 = new Performer("Roman");
            Performer worker2 = new Performer("Alex");

            Task[] tasks =  {new Task(worker1,"Write new console app with 3 classes."), new Task(worker2,"Play dota 2 in the evening.")};

            Board board = new Board(tasks);          
            board.ShowTasks();

            Console.ReadKey();
        }

        class Performer
        {
            public string Name;

            public Performer(string name)
            {
                Name = name;
            }
        }

        class Task
        {
            public Performer Worker;
            public string Description;

            public Task(Performer worker, string description)
            {
                Worker = worker;
                Description = description;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Ответственный: {Worker.Name}\nЗадача:{Description}\n");
            }

        }

        class Board
        {
            public Task[] Tasks;

            public Board(Task[] tasks)
            {
                Tasks = tasks;
            }

            public void ShowTasks()
            {
                for(int i = 0; i < Tasks.Length; i++)
                {
                    Tasks[i].ShowInfo();
                }
            }

        }
    }
}
