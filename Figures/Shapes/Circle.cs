namespace Figures.Shapes {
    public class Circle: IFigure {
        private readonly double r;
        public Circle(double radius) {
            r = radius;
            CheckRadius();
        }

        public double GetArea() => Math.PI * r * r;

        private void CheckRadius() {
            if(r <= 0)
                throw new ArgumentException("Радиус должен быть больше нуля");
        }
    }
}
