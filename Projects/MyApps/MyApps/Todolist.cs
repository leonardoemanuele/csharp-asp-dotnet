using System;
namespace MyApps
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            foreach(string todo in Todos)
                {
                if (todo != null)
                {
                    Console.WriteLine($"-{todo}\n");
                }
                else
                {
                    continue;
                }
                
            }
        }

        public void Reset()
        {
            Array.Clear(Todos, 0, Todos.Length);
            nextOpenIndex = 0;
            Console.WriteLine("Todos array is empty\n");

        }
    }
}
