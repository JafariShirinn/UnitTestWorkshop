namespace StreamingService.Clients
{
    public class StreamingClient
    {
        public void StartStreaming(string movieName)
        {
            Console.ForegroundColor = ConsoleColor.Green; // Set text color to red for warning

            Console.WriteLine($"Welcome to Movie {movieName} Streaming");
            Console.WriteLine("Press Enter to start streaming...");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Streaming in progress:");
            Console.WriteLine("  [===========]");

            // Simulate the progress animation
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("\r  [");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("=");
                }
                for (int j = i; j < 10; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("]");

                Thread.Sleep(500); // Sleep for half a second to simulate loading
            }

            Console.WriteLine("\n\nMovie stream complete.");
            Console.ResetColor(); // Reset text color to default
        }
    }
}
