﻿using System;
using System.IO;
using System.Messaging;
using MultipleQueueListener.Interfaces;

namespace MultipleQueueListener.Queues
{
    public class Sales : IMessageQueueHandler
    {
        private MessageQueue _queue;
        private readonly string _queueName;

        public Sales()
        {
            this._queueName = @".\Private$\Sales";
        }

        public void StartRead()
        {
            if (!MessageQueue.Exists(_queueName))
                throw new Exception();

            _queue = new MessageQueue(_queueName) {Formatter = new XmlMessageFormatter(new Type[] {typeof (string)})};
            _queue.PeekCompleted += new PeekCompletedEventHandler(QueuePeekCompleted);
            _queue.BeginPeek();
        }

        private void QueuePeekCompleted(object sender, PeekCompletedEventArgs e)
        {
            Message message = _queue.EndPeek(e.AsyncResult);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nA message was read from the Sales queue.");
            Console.WriteLine(string.Format("The message was: {0}", message.Body));

            _queue.Receive();
            _queue.BeginPeek();
        }

        public override string ToString()
        {
            return _queueName;
        }
    }
}
