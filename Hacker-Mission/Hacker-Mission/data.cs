namespace data;

using System;
using System.IO;
using System.Text.Json;

public static class func
{
    public static void Database()
    {
        string filePath = "data.json"; // coloque data.json na mesma pasta do .exe
        /*if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found: " + filePath);
            return;
        }*/

        string json = File.ReadAllText(filePath);

        // Parse segura para JsonElement
        JsonElement root;
        try
        {
            root = JsonSerializer.Deserialize<JsonElement>(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed to parse JSON: " + ex.Message);
            return;
        }

        if (!root.TryGetProperty("devices", out JsonElement devicesElement) ||
            devicesElement.ValueKind != JsonValueKind.Array)
        {
            Console.WriteLine("JSON does not contain a 'devices' array.");
            return;
        }

        // Header simples
        Console.WriteLine("{0,-10} {1,-20} {2,-12} {3,-15} {4,-10} {5,-20}",
            "ID", "Name", "Type", "IP", "Status", "Last Seen");
        Console.WriteLine(new string('-', 90));

        foreach (JsonElement device in devicesElement.EnumerateArray())
        {
            string id = device.GetProperty("id").GetString() ?? "";
            string name = device.GetProperty("name").GetString() ?? "";
            string type = device.GetProperty("type").GetString() ?? "";
            string ip = device.GetProperty("ip").GetString() ?? "";
            string status = device.GetProperty("status").GetString() ?? "";
            string lastSeen = device.GetProperty("last_seen").GetString() ?? "";

            Console.WriteLine("{0,-10} {1,-20} {2,-12} {3,-15} {4,-10} {5,-20}",
                id, name, type, ip, status, lastSeen);

            Console.WriteLine("Logs:");
            Console.WriteLine("{0,-25} {1,-50} {2,-10}", "Timestamp", "Event", "Level");

            if (device.TryGetProperty("logs", out JsonElement logsElement) &&
                logsElement.ValueKind == JsonValueKind.Array)
            {
                foreach (JsonElement log in logsElement.EnumerateArray())
                {
                    string ts = log.GetProperty("timestamp").GetString() ?? "";
                    // "event" is a valid JSON property; aqui acessamos com GetProperty("event")
                    string ev = log.TryGetProperty("event", out var evProp) ? evProp.GetString() ?? "" : "";
                    string level = log.TryGetProperty("level", out var lvlProp) ? lvlProp.GetString() ?? "" : "";

                    Console.WriteLine("{0,-25} {1,-50} {2,-10}", ts, ev, level);
                }
            }
            else
            {
                Console.WriteLine("(no logs)");
            }

            Console.WriteLine(new string('-', 90));
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

