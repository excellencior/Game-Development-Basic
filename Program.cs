// See https://aka.ms/new-console-template for more information
class HelloWorld {
    static void Main() {
        string[] nameList = new string[4];

        for (int i=0; i<nameList.Length; i++) {
            nameList[i] = Console.ReadLine();
        }

        Console.WriteLine("\nYour names --- \n");
        for (int i=0; i<nameList.Length; i++) {
            Console.WriteLine((i+1) + ": " + nameList[i]);
        }

        Console.ReadKey(); // await for a key press
    }
}


