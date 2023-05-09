class HelloWorld {
    static void Main() {
        int roll1 = -1, roll2 = 0, attempts = 0;

        Random randNumGen = new Random();

        while (roll1 != roll2) {
            roll1 = randNumGen.Next(1, 7);
            roll2 = randNumGen.Next(1, 7);

            Console.WriteLine("Roll-1: " + roll1);
            Console.WriteLine("Roll-2: " + roll2);
            Console.WriteLine();
            attempts++;
        }

        Console.WriteLine("Total Attempts: " + attempts);
        Console.ReadKey(); // await for a key press
    }
}
