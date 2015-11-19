using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMessaging
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ExecuteTask(Tasks.SendPrivate);
            program.ExecuteTask(Tasks.ReceivePrivate);
        }

        private String privateQueueName = @".\Private$\newPrivQueue";
        private String publicQueueName = @".\newPubQueue";

        public enum Tasks
        {
            SendPrivate, SendPublic, ReceivePrivate, ReceivePublic
        }

        public void ExecuteTask(Tasks task)
        {
            try
            {
                switch (task)
                {
                    case Tasks.SendPrivate:
                        SendPrivate();
                        break;
                    case Tasks.SendPublic:
                        SendPublic();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void SendPrivate()
        {
            MessageQueue mpPrivateQueue = !MessageQueue.Exists(privateQueueName) ? MessageQueue.Create(privateQueueName) : new MessageQueue(privateQueueName);
            mpPrivateQueue.Send("My message data.");
            mpPrivateQueue.Close();
        }

        private void SendPublic()
        {
            MessageQueue mqPubQueue = !MessageQueue.Exists(publicQueueName) ? MessageQueue.Create(publicQueueName) : new MessageQueue(publicQueueName);
            mqPubQueue.Send("My message data.");
            mqPubQueue.Close();
        }

        private void ReceivePrivate()
        {

        }

        private void ReceivePublic()
        {

        }

    }
}
