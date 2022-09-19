using Figures.Shapes;

namespace TestFigures {
    public class TriangleTests {
        [Test]
        public void TestAreaOfTriangle() {
            Triangle t = new Triangle(4, 5, 3);

            var area = t.GetArea();

            Assert.AreEqual(6, area);
        }

        [TestCase(-1, 3 ,4 )]
        [TestCase(4, -1, 6)]
        [TestCase(2, 0, 3)]
        public void TestTriangleWithBadSides(double a, double b, double c) {
            Triangle t;
            Assert.Throws<ArgumentException>(
                () => t = new Triangle(a,b,c)
                );
        }


        [TestCase(1, 3 ,5 )]
        [TestCase(4, 1, 6)]
        [TestCase(2, 1, 4)]
        public void TestUnexistedTriangle(double a, double b, double c) {
            Triangle t;
            Assert.Throws<ArgumentException>(
                () => t = new Triangle(a,b,c)
                );
        }

        public void TestTriangleIsRight() {
            Triangle t1 = new Triangle(3, 5, 4);
            Triangle t2 = new Triangle(8, 10, 6);

            Triangle t3 = new Triangle(3, 6, 5);
            Triangle t4 = new Triangle(8, 10, 7);

            Assert.True(t1.IsRight());
            Assert.True(t2.IsRight());

            Assert.False(t3.IsRight());
            Assert.False(t4.IsRight());
        }
    }
}
