namespace Figures.Shapes {
    public class Circle: IFigure {
        private double radius;
        public double Radius {
            get {
                return radius;
            }
            private set {
                if (value <= 0) {
                    throw new ArgumentException();
                }
                radius = value;
            }
        }
        public Circle(double radius) {
            Radius = radius;
        }
        public double GetArea() {
            return Math.PI * Radius * Radius;
        }
    }
}
