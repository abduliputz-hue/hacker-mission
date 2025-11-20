namespace data;
using System;
using System.IO;
using System.Text.Json;

public static class func
{
    public static void database()
    {
        string filePath = "data.json"; // your JSON file
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        string json = File.ReadAllText(filePath);

        // Parse JSON dynamically
        var root = JsonSerializer.Deserialize<dynamic>(json);

        Console.WriteLine("{0,-10} {1,-20} {2,-12} {3,-15} {4,-10} {5,-20}",
            "ID", "Name", "Type", "IP", "Status", "Last Seen");
        Console.WriteLine(new string('-', 90));

        foreach (var device in root.devices.EnumerateArray())
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-12} {3,-15} {4,-10} {5,-20}",
                device.GetProperty("id").GetString(),
                device.GetProperty("name").GetString(),
                device.GetProperty("type").GetString(),
                device.GetProperty("ip").GetString(),
                device.GetProperty("status").GetString(),
                device.GetProperty("last_seen").GetString()
            );

            Console.WriteLine("Logs:");
            Console.WriteLine("{0,-25} {1,-50} {2,-10}", "Timestamp", "Event", "Level");

            foreach (var log in device.GetProperty("logs").EnumerateArray())
            {
                Console.WriteLine("{0,-25} {1,-50} {2,-10}",
                    log.GetProperty("timestamp").GetString(),
                    log.GetProperty("event").GetString(),
                    log.GetProperty("level").GetString()
                );
            }

            Console.WriteLine(new string('-', 90));
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}


