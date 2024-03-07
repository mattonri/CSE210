

using System.ComponentModel.DataAnnotations;

public class Resume 
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }


    public void AddJob(string _company= "", string _jobTitle= "", int _startYear= 0,
    int _endYear= 0)
    {
        Job defaultJobName = new Job();
        defaultJobName._company = _company;
        defaultJobName._jobTitle = _jobTitle;
        defaultJobName._startYear = _startYear;
        defaultJobName._endYear = _endYear;
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