using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSender
{
    class Program
    {
        public static String privateQueueName = @"FormatName:Direct=OS:pc-joel\Private$\newPrivQueue1";
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(1000);
            try
            {
                Example2();
                Exercise1();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        static void Example2()
        {
            Console.WriteLine("Example2");
            MessageQueue queue = new MessageQueue(privateQueueName);

            queue.Send("Hello!");
            queue.Close();

            Console.WriteLine("End");
            Console.WriteLine();
        }

        static void Exercise1()
        {
            Console.WriteLine("Exercise1");
            MessageQueue queue = new MessageQueue(privateQueueName);
            List<Record> records = new List<Record>();
            for (Int64 i = 0; i < Int16.MaxValue; i++)
            {
                Record record = new Record();
                record.Subject = "Record Subject " + i;
                record.Body = "Record Body " + i;
                records.Add(record);
            }

            queue.Send(records);
            queue.Close();

            Console.WriteLine("End");
            Console.WriteLine();
        }
    }
}
