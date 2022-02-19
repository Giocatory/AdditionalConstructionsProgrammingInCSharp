namespace AdditionalLibrary
{
    public class SportsCar : Car
    {
        public SportsCar()
        {
        }
        public SportsCar(string name, int maxSp, int currSp) : base(name, maxSp, currSp) { }
        public override void TurboBoost()
        {
            Console.WriteLine("Ramming speed! Faster is better...");
        }
    }
    public class MiniVan : Car
    {
        public MiniVan()
        {
        }
        public MiniVan(string name, int maxSp, int currSp) : base(name, maxSp, currSp) { }
        public override void TurboBoost()
        {
            egnState = EngineState.engineDead;
            Console.WriteLine("Eek! Your engine block exploded!");
        }
    }
}
