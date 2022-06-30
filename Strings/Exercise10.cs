// See https://aka.ms/new-console-template for more informationint

string text = Console.ReadLine();
string word = Console.ReadLine();   
int dotIndex = 0; int previousDotIndex = 0;
char[] separators = { ' ', ',', '.' };
bool exist = false;

while(dotIndex >= 0 && previousDotIndex < text.Length)
{
    dotIndex = text.IndexOf('.', dotIndex + 1); //marks the end index of first sentence
    string sentence = text.Substring(previousDotIndex, dotIndex - previousDotIndex + 1); //takes first sentence

    for(int j = 0; j < sentence.Length; j++)
    {
        int exists = 0;
        for (int k = 0; k < separators.Length; k++)
        {
            exist = false;
            if ((exists = sentence.IndexOf(" " + word + separators[k])) >= 0)
            {
                Console.WriteLine(sentence);
                exist = true;
                break;
            }
        }
        if (exist)
        {
            break;
        }
    }
        previousDotIndex = dotIndex + 2;

      }

     
