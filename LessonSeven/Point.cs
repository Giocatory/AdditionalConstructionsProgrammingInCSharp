namespace LessonSeven
{
    internal class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => $"[{x}; {y}]";

        public static Point operator +(Point p1, Point p2) => new(p1.x + p2.x, p1.y + p2.y);

        public static Point operator -(Point p1, Point p2) => new(p1.x - p2.x, p1.y - p2.y);

        public static Point operator ++(Point p1) => new(p1.x + 1, p1.y + 1);

        public static Point operator --(Point p1) => new(p1.x - 1, p1.y - 1);
    }
}