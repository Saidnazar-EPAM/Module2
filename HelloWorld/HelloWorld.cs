using System;

namespace HelloWorld
{
    public static class HelloWorld
    {
        public static string Concat(string username)
        {
            return $"{DateTime.Now.TimeOfDay} Hello, {username}";
        }
    }
}
