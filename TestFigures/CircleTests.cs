namespace TestFigures {
    public class CircleTests {

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        public void TestAreaOfCircle(double radius) {
            IFigure c = ShapeFactory.CreateCircle(radius);

            var area = c.GetArea();

            Assert.That(area, Is.EqualTo(radius * radius * Math.PI));
        }

        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(0)]
        public void TestCircleWithBadRadius(double radius) {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateCircle(radius));
        }
    }
}