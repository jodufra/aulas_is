using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReceiver
{
    class Program
    {
        public static String privateQueueName = @".\Private$\newPrivQueue1";

        static void Main(string[] args)
        {
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
            MessageQueue mpPrivateQueue = !MessageQueue.Exists(privateQueueName) ? MessageQueue.Create(privateQueueName) : new MessageQueue(privateQueueName);
            Console.WriteLine("Waiting for msgs...");

            mpPrivateQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });
            Console.WriteLine((String)mpPrivateQueue.Receive().Body);
            mpPrivateQueue.Close();

            Console.WriteLine("End");
            Console.WriteLine();
        }

        static void Exercise1()
        {
            Console.WriteLine("Exercise1");
            MessageQueue mpPrivateQueue = !MessageQueue.Exists(privateQueueName) ? MessageQueue.Create(privateQueueName) : new MessageQueue(privateQueueName);
            Console.WriteLine("Waiting for msgs...");

            mpPrivateQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(Record[]) });

            Record[] records = (Record[])mpPrivateQueue.Receive().Body;
            foreach (var record in records)
            {
                Console.WriteLine(record.ToString());
            }

            mpPrivateQueue.Close();

            Console.WriteLine("End");
            Console.WriteLine();
        }
    }
}
