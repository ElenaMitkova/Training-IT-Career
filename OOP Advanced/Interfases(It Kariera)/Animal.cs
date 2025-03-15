namespace Interfases_It_Kariera_
{
    internal abstract class Animal : IMakeNoise, IMakeTrick
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string MakeNoise()
        {
            return $"My name is {Name}. I am {Age} old.";
        }
        public string MakeTrick()
        {
            return "Look at my trick!";
        }
    }
}