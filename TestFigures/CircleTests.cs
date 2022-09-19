using Figures.Shapes;

namespace TestFigures {
    public class CircleTests {

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        public void TestAreaOfCircle(double radius) {
            Circle c = new Circle(radius);

            var area = c.GetArea();

            Assert.AreEqual(radius * radius * Math.PI, area);
        }

        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(0)]
        public void TestCircleWithBadRadius(double radius) {
            Circle c;
            Assert.Throws<ArgumentException>(
                () => c = new Circle(radius)
                );
        }
    }
}