namespace BookStore
{
    using Engine;
    using Interfaces;
    using UI;

    public class BookStoreMain
    {
        public static void Main()
        {
            var renderer = new ConsoleRenderer();
            var inputHandler = new ConsoleInputHandler();

            BookStoreEngine engine = new BookStoreEngine(renderer, inputHandler);

            engine.Run();
        }
    }
}
