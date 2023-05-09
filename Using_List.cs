// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
class HelloWorld {
    static void Main() {
        // string[] nameList = new string[4];

        // for (int i=0; i<nameList.Length; i++) {
        //     nameList[i] = Console.ReadLine();
        // }

        // Console.WriteLine("\nYour names --- \n");
        // for (int i=0; i<nameList.Length; i++) {
        //     Console.WriteLine((i+1) + ": " + nameList[i]);
        // }

        // List => For undefined sized arrays (using System.Collections.Generic)

        List<string> bucketList = new List<string>();

        bucketList.Add("Keep miss and my family happy");
        bucketList.Add("Control your emotions");

        Console.WriteLine("My Bucket List: ");
        for (int i=0; i<bucketList.Count; i++) {
            Console.WriteLine(bucketList[i]);
        }

        Console.ReadKey(); // await for a key press
    }
}


