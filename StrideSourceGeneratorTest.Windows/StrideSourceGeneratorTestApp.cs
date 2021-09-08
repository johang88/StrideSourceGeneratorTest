using Stride.Engine;

namespace StrideSourceGeneratorTest
{
    class StrideSourceGeneratorTestApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
