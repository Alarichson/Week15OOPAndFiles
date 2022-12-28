internal class Program
{
    //Anna wants new earrings for Christmas
    class Wish
    {
        string reciver;
        string present;
        public Wish(string _reciver, string _present)
        {
            reciver = _reciver;
            present = _present;
        }
        public string Reciver
        {
            get { return reciver; }
        }
        public string Present
        {
            get { return present; }
        }
    }
    static void Main(string[] args)
    {
        List<Wish> myWish = new List<Wish>();
        string[] PresentFile = GetDataFromFile();
        foreach (string line in PresentFile)
        {
            string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            Wish newWish = new Wish(tempArray[0], tempArray[1]);
            myWish.Add(newWish);
        }
        foreach (Wish PresentFromList in myWish)
        {
            Console.WriteLine($"{PresentFromList.Reciver} wishes for {PresentFromList.Present}");
        }
    }
    public static void DisplayElementsFromArray(string[] someArray)
    {
        foreach (string element in someArray)
        {
            Console.WriteLine($"String from array {element}");
        }
    }
    public static string[] GetDataFromFile()
    {
        string filePath = @"D:\OneDrive\TKTK\Programmeerimise algkursus (RKE132) -\Samples\frozen.txt";
        string[] dataFromFile = File.ReadAllLines(filePath);
        return dataFromFile;
    }
}