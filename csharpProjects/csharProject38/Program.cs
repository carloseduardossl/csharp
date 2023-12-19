string status = "Healthy";

void SetHealth(bool isHealthy)
{
    status = (isHealthy? "Healthy":"Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");