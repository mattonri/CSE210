

using System.ComponentModel.DataAnnotations;

public class Resume 
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {

    }

    public void InitializeJob()
    {
        Job defaultJobName = new Job();
        _jobs.Add(defaultJobName);
    }
    
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}