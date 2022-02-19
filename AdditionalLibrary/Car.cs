namespace AdditionalLibrary
{
    public enum EngineState
    {
        engineAlive,
        engineDead,
    }

    public abstract class Car
    {
        public string? PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        protected EngineState? egnState = EngineState.engineAlive;
        public EngineState? EgnState => egnState;

        public abstract void TurboBoost();

        public Car()
        { }

        public Car(string name, int maxSp, int currSp)
        {
            PetName = name;
            MaxSpeed = maxSp;
            CurrentSpeed = currSp;
        }
    }
}