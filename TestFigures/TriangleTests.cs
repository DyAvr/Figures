using Figures;

namespace TestFigures {
    public class TriangleTests {
        [Test]
        public void TestAreaOfTriangle() {
            IFigure t = ShapeFactory.CreateTriangle(4, 5, 3);

            var area = t.GetArea();

            Assert.That(area, Is.EqualTo(6));
        }

        [TestCase(-1, 3, 4)]
        [TestCase(4, -1, 6)]
        [TestCase(2, 0, 3)]
        public void TestTriangleWithBadSides(double a, double b, double c) {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateTriangle(a, b, c));
        }


        [TestCase(1, 3, 5)]
        [TestCase(4, 1, 6)]
        [TestCase(2, 1, 4)]
        public void TestUnexistedTriangle(double a, double b, double c) {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateTriangle(a, b, c));
        }

        [TestCase(3, 5, 4)]
        [TestCase(8, 10, 6)]
        public void TestTriangleIsRight(double a, double b, double c) {
            var t = (Triangle)ShapeFactory.CreateTriangle(a,b,c);

            Assert.True(t.IsRight());
        }

        [TestCase(3, 6, 5)]
        [TestCase(8, 10, 7)]
        public void TestTriangleIsNotRight(double a, double b, double c) {
            var t = (Triangle)ShapeFactory.CreateTriangle(a,b,c);

            Assert.False(t.IsRight());
        }
    }
}
