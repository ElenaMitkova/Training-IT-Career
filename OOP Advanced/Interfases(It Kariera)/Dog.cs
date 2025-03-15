namespace Interfases_It_Kariera_
{
    internal class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {

        }
        public string MakeNoise()
        {
            return "Woof!" + base.MakeNoise();
        }
        public string MakeTrick()
        {
            return "Hold my paw, human!" + base.MakeTrick();
        }
    }
}