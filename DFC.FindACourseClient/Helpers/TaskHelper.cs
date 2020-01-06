﻿using System;
using System.Threading.Tasks;

namespace DFC.FindACourseClient
{
    internal static class TaskHelper
    {
        private static readonly Action<Task> SwallowError = t =>
        {
            try
            {
                t.Wait();
            }
            catch
            {
                //swallow error
            }
        };

        public static void ExecuteNoWait(Action action, Action<Exception> handler = null)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            var task = Task.Run(action);
            const TaskContinuationOptions taskContinuationOptions = TaskContinuationOptions.ExecuteSynchronously | TaskContinuationOptions.OnlyOnFaulted;

            task.ContinueWith(handler is null ? SwallowError : t => handler(t.Exception.GetBaseException()), taskContinuationOptions);
        }
    }
}