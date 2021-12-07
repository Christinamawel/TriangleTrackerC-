using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Models;

namespace Triangle.Models.Test
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_ReturnsTriangleWithThreeSides_Int()
    {
      Triangle test = new Triangle(4,5,6);
      Assert.AreEqual(4, test.SideOne);
      Assert.AreEqual(5, test.SideTwo);
      Assert.AreEqual(6, test.SideThree);
    }
  }
}