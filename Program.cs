namespace Dicionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // criar uma estrutura de dados 

            Dictionary<string, int> dicionary = new Dictionary<string, int>();


            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr  = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] votingRecord = sr.ReadLine().Split(",");

                        string candidate = votingRecord[0]; 

                        int votes = int.Parse(votingRecord[1]);


                        // verificar se o name do candidado ja tem algum voto, se tiver entao

                        if (dicionary.ContainsKey(candidate))
                        {
                            dicionary[candidate] += votes; 
                        } 
                        else
                        {
                            dicionary[candidate] = votes; 
                        }
                    }

                    // listar toda a e4strutura de dados 

                    foreach (var item in dicionary)
                    {
                        Console.WriteLine($"{item.Key} : {item.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
