namespace LessonFour
{
    internal struct Point<T>
    {
        // Обобщенные данные состояния,
        private T xPos;

        private T yPos;

        // Обобщенный конструктор,
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        // Обобщенные свойства,
        public T X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public T Y
        {
            get { return yPos; }
            set { yPos = value; }
        }

        public override string ToString() => $"({xPos}; {yPos})";

        // Сбросить поля в стандартные значения
        // для заданного параметра типа,
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
    }
}