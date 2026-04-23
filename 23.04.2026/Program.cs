namespace ClassWork
{
    public class Program
    {
        public static void Main()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //System.Console.WriteLine(folderPath);

            string fileName = "example.txt";

            string fullPath = Path.Combine(folderPath, fileName);

            //System.Console.WriteLine(fullPath);

            File.Create(fullPath).Close();
            File.WriteAllText(fullPath, "hello" + Environment.NewLine); //перазеписывает всю информацию
            File.AppendAllText(fullPath, "world");
            File.WriteAllText(fullPath, "hi again");

            string[] words = ["wohoo", "so", "funny"];
            File.WriteAllLines(fullPath, words);
            File.AppendAllLines(fullPath, words);
            File.AppendAllText(fullPath, "text");
            File.AppendAllText(fullPath, "text");
            File.AppendAllText(fullPath, "text");

            string content = File.ReadAllText(fullPath);
            string[] Lines = File.ReadAllLines(fullPath);
            // System.Console.WriteLine(content);
            // System.Console.WriteLine(string.Join(" ", Lines));

            string folderPath2 = Path.Combine(folderPath, "ExampleFolder");
            string filePath = Path.Combine(folderPath2, "anotherExample.txt");

            if (Directory.Exists(folderPath2))
            {
                Directory.CreateDirectory(folderPath2);
            }
            if (File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            else
            {
                File.WriteAllText(filePath, "");
            }

            //знаем ТОЛЬКО полный путь
            string folderPath3 = Path.GetDirectoryName(filePath);
            string fileName2 = Path.GetFileName(filePath);
            // System.Console.WriteLine(folderPath3);
            // System.Console.WriteLine(fileName2);
        }
    }
}
