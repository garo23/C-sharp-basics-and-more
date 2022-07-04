// Write a program that reads a string from the console and prints in alphabetical
// order all letters from the input string and how many
// times each one of
// them occurs in the string.
class Exercise22
{
    public static void TryHard(string input){



        Dictionary<char, int> dic = new Dictionary<char, int>();
        

        for (int i = 0; i < input.Length; i++) {
            bool check = Char.IsLetter(input[i]);
            if (check == true)
            {

                if (dic.ContainsKey(input[i]))
                {
                    dic[input[i]]++;

                }
                else
                {
                    dic.Add(input[i], 1);
                }
            }
        }
        foreach (KeyValuePair<char, int> kvp in dic)
        {
            //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
        

  }
}
