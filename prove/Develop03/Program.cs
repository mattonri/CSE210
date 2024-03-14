using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        // mrtWord poofWord = new mrtWord("poof");
        // poofWord.mrtHide();
        // Console.WriteLine(poofWord.mrtReturnString());
        // mrtPassage test = new mrtPassage("This is a super short passage");
        // Console.WriteLine(test.mrtReturnString());
        mrtScripture mrtselectedScripture = new mrtScripture("Ether 12:4", "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.");
        string userInput = "";
        Console.WriteLine("Hello! Today, you will be memorizing the following scripture below! Just enter to continue or type 'quit' if you would like to quit!");
        while(userInput.ToLower() != "quit")
        {
            Console.WriteLine(mrtselectedScripture.mrtReturnString());
            userInput = Console.ReadLine();
            if (mrtselectedScripture.mrtHideWord())
            {
                userInput = "quit";
                Console.Clear();
                Console.WriteLine("Congrats! That's all the words. Now see if you can do it fully from memory:\n");
                Console.WriteLine(mrtselectedScripture.mrtReturnString());
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
            }
        }

    }
}