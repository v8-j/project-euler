// Using 0022_names.txt, a 46K text file containing over five-thousand first 
// names, begin by sorting it into alphabetical order. Then working out the 
// alphabetical value for each name, multiply this value by its alphabetical
// position in the list to obtain a name score.
// For example, when the list is sorted into alphabetical order, COLIN, which is
// worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN
// would obtain a score of 938 * 53 = 49714.
// What is the total of all the name scores in the file?

class Names_Scores
{
    public static void Run()
    {
        // Read names from the file, each name is wrapped in quotes, and names
        // are seperated by commas
        string path = "src/1-50/0022_names.txt";
        string allText = File.ReadAllText(path);
        string[] namesWrapped = allText.Split(',');

        // Create a list, strip the quotes and add the names to the list, then
        // sort alphabetically
        List<string> names = new List<string>();
        foreach (string name in namesWrapped)
            names.Add(name.Substring(1, name.Length - 2));
        names.Sort();

        // Calculate the score for each name, summing the value for each letter,
        // then multiplying that by its position in the list (i+1)
        // A-Z = 65-90 
        long total = 0;
        for (int i = 0; i < names.Count; ++i)
        {
            int sum = 0;
            string name = names[i];
            for (int j = 0; j < name.Length; ++j)
                sum += name[j] - 64;
            sum *= (i + 1);
            total += sum;
        }
        
        Console.WriteLine($"The total score for all names is {total}");

    }
}
