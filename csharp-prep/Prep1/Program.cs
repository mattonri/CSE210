using System;

class Program
{
    static void Main(string[] args)
    {

        static int compute_jumps(int n)
    {
        List<int> options = new List<int>();
        List<int> jumpsList = new List<int>();
        for(int i = 1; i <= n; ++i)
        {
            options.Add(i);
        }
        foreach(int option in options)
        {
            int _runningValue = option;
            int jumps = 0;
            while(_runningValue != 1)
            {
                if(_runningValue % 2 == 0)
                {
                    _runningValue = _runningValue / 2;
                }
                else
                {
                    _runningValue = _runningValue * 3 + 1;
                }
                ++jumps;
            }
            jumpsList.Add(jumps);
        }
        int mostJumps = -1;
        foreach(int jump in jumpsList)
        {
            if(jump > mostJumps)
            {
                mostJumps = jump;
                Console.WriteLine($"most jumps updating: {mostJumps}");
            }
        }
        int resultAlmost = jumpsList.FindIndex(x => x==mostJumps) + 1;
        int resultJumps = 0;
        while(resultAlmost != 1)
        {
            if(resultAlmost % 2 == 0)
            {
                resultAlmost = resultAlmost / 2;
            }
            else
            {
                resultAlmost = resultAlmost * 3 + 1;
            }
            ++resultJumps;
        }



        return resultJumps;
        
    }
    Console.WriteLine(compute_jumps(10));
    Console.WriteLine(compute_jumps(5));

    }
    
}

class Result
{

    

}