namespace Triangle.Models
{
  public class Triangle
  {
    public int SideOne { get; }
    public int SideTwo { get; }
    public int SideThree { get; }

    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }
  }
}

