namespace Figures.Shapes {
    public class Triangle: IFigure {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
            CheckForExistence();
        }

        public double GetArea() {
            var p = EvaluateHalfPerimeter();
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRight() {
            double C = Math.Max(Math.Max(a, b), c);
            double A = Math.Min(Math.Min(a, b), c);
            double B = a + b + c - C - A;
            return C * C == A * A + B * B;
        }

        private void CheckForExistence() {
            if(a <= 0 | b <= 0 | c <= 0)
                throw new ArgumentException("Сторона должна быть больше нуля");
            if(a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Треугольник с такими сторонами не существует");
        }

        private double EvaluateHalfPerimeter() => (a + b + c) / 2;
    }
}
