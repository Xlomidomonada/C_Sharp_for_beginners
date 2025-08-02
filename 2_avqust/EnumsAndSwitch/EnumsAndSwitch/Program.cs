using System.ComponentModel;

namespace EnumsAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo {Description = "Task1", EstimatedHours = 6, Status = Status.Completed},
                new Todo {Description = "Task2", EstimatedHours = 2, Status = Status.InProgress},
                new Todo {Description = "Task3", EstimatedHours = 8, Status = Status.NotStarted},
                new Todo {Description = "Task4", EstimatedHours = 12, Status = Status.OnHold},
                new Todo {Description = "Task5", EstimatedHours = 17, Status = Status.Completed},
                new Todo {Description = "Task6", EstimatedHours = 2, Status = Status.OnHold},
                new Todo {Description = "Task7", EstimatedHours = 6, Status = Status.Deleted},
                new Todo {Description = "Task8", EstimatedHours = 67, Status = Status.OnHold},
                new Todo {Description = "Task9", EstimatedHours = 4, Status = Status.NotStarted},
                new Todo {Description = "Task10", EstimatedHours = 23, Status = Status.Deleted},
                new Todo {Description = "Task11", EstimatedHours = 10, Status = Status.NotStarted},
                new Todo {Description = "Task12", EstimatedHours = 1, Status = Status.Deleted}
            };

            PrintAssesment(todos);
        }

        private static void PrintAssesment(List<Todo> todos)
        {
            foreach ( var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("ENUM");
            }
        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }
}
