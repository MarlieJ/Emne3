class Program
{
    static void Main(string[] args)
    {
        // Define the tempo (in milliseconds)
        int tempo = 100;

        // Define the notes (frequency, duration)
        int[,] notes = new int[,] {
                { 203, tempo },
                { 387, tempo },
                { 459, tempo },
                { 587, tempo },
                { 423, tempo },
                { 387, tempo },
                { 259, tempo },
                { 187, tempo },
                { 203, tempo },
                { 387, tempo },
                { 459, tempo },
                { 587, tempo },
                { 423, tempo },
                { 459, tempo },
                { 387, tempo },
                { 259, tempo },
                { 459, tempo },
                { 259, tempo },
                { 459, tempo },
                { 259, tempo },
                { 459, tempo },
                { 459, tempo },
                { 459, tempo },
                { 259, tempo },
                { 459, tempo },
                { 459, tempo },
                { 259, tempo },
                { 459, tempo },
                { 259, tempo },
                { 459, tempo },
                { 259, tempo },
            };

        // Play the notes
        for (int i = 0; i < notes.GetLength(0); i++)
        {
            int frequency = notes[i, 0];
            int duration = notes[i, 1];
            Console.Beep(frequency, duration);
        }

        Console.ReadKey();
    }
}