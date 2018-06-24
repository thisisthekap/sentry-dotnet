using System;

namespace Sentry.Tests.Helpers
{
    internal static class EnvironmentVariableGuard
    {
        // To allow different xunit colletions use of this
        private static readonly object Lock = new object();

        public static void WithVariable(string key, string value, Action action)
        {
            lock (Lock)
            {
                Environment.SetEnvironmentVariable(key, value, EnvironmentVariableTarget.Process);
                try
                {
                    action();
                }
                finally
                {
                    Environment.SetEnvironmentVariable(key, null, EnvironmentVariableTarget.Process);
                }
            }
        }
    }
}
