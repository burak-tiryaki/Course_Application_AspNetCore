namespace BurakAkademi.Models;

public static class Repository
{
    private static List<Candidate> applications = new();

    public static List<Candidate> Applications => applications;

    public static void Add(Candidate candidate)
    {
        applications.Add(candidate);
    }
}