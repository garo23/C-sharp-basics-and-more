public class TxtFile
{
    public void ReadFile(String filename)
    {
        StreamReader reader = null;
        try
        {
            reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);

            }
            reader.Close();

        } catch (FileNotFoundException)
        
        {
               Console.WriteLine("The file '{0}' does not exist.", filename);


        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if(reader != null)
            {

                reader.Close();
            }

        }
    
    }

}