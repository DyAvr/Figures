namespace Figures.Shapes {
    public class Triangle: IFigure {
        private double p;
        private double a;
        private double b;
        private double c;
        public double A {
            get {
                return a;
            }
            private set {
                if(value <= 0) {
                    throw new ArgumentException();
                }
                a = value;
            }
        }
        public double B {
            get {
                return b;
            }
            private set {
                if(value <= 0) {
                    throw new ArgumentException();
                }
                b = value;
            }
        }
        public double C {
            get {
                return c;
            }
            private set {
                if(value <= 0) {
                    throw new ArgumentException();
                }
                c = value;
            }
        }
        public Triangle(double a, double b, double c) {
            A = a;
            B = b;
            C = c;
            CheckForExistence();
        }

        private void CheckForExistence() {
            if (A+B<C || A+C<B || B + C < A) {
                throw new ArgumentException();
            }
        }

        public double GetArea() {
            EvaluateHalfPerimeter();
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        private void EvaluateHalfPerimeter() {
            p = (A + B + C) / 2;
        }
        public bool IsRight() {
            double c = Math.Max(Math.Max(A, B), C);
            double a = Math.Min(Math.Min(A, B), C);
            double b = A + B + C - c - a;
            return c * c == a * a + b * b;
        }
    }
}
