using BusinessEntities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Retrieve the list of vehicles
            List<Fordon> fordonList = FordonRepository.GetAllFordon();

            // Check if the retrieval was successful
            Console.WriteLine($"Total vehicles loaded: {fordonList.Count}");
            Console.WriteLine("List of Vehicles:");
            Console.WriteLine("-----------------");

            // Display each vehicle's details
            foreach (var fordon in fordonList)
            {
                Console.WriteLine($"ID: {fordon.FordonsID}, Position: {fordon.Position}, Status: {fordon.Status}, Type: {fordon.FordonsTyp}");
            }

            // Wait for user input before closing the console window
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}