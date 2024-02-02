namespace StaticStructExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The dog breed and size is:");
            string breed = Dogs.Breed;
            int height = Dogs.Height;
            Console.WriteLine($"The {breed} are around {height} cm tall.");
        }
    }
}
