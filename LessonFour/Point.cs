namespace LessonFour
{
    internal struct Point<SomeType>
    {
        // Обобщенные данные состояния,
        private SomeType xPos;

        private SomeType yPos;

        // Обобщенный конструктор,
        public Point(SomeType xVal, SomeType yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        // Обобщенные свойства,
        public SomeType X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public SomeType Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString() => $"({xPos}; {yPos})";

        // Сбросить поля в стандартные значения
        // для заданного параметра типа SomeType,
        public void ResetPoint()
        {
            xPos = default(SomeType);
            yPos = default(SomeType);
        }
    }
}