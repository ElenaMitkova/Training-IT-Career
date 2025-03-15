namespace Interfases_It_Kariera_
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {

        }
        public string MakeNoise()
        {
            return "Meow!" + base.MakeNoise();
        }
        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!" + base.MakeTrick();
        }
    }
}