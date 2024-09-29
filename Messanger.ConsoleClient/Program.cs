using Newtonsoft.Json;
using System;

namespace Messanger.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message("Yaroslav", "Hello World!", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(message);
            Console.WriteLine(output);

            Message deserializedMessage = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMessage);

            // {"UserName":"Yaroslav","MessageText":"Hello World!","TimeStamp":"2024-09-29T09:50:31.7364167Z"}
            // Yaroslav <29.09.2024 9:50:31>: Hello World!
        }
    }
}