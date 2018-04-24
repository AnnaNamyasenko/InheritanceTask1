using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                TaskImplementation Task = new TaskImplementation();
                Task.Execute();
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();
        }
    }
}
