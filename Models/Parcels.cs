namespace Parcel.Models

{
  public class ParcelVariables
  {
    private float _height;
    private float _width;
    private float _depth;
    private float _weight;

    public float GetHeight()
    {
      return _height;
    }
    public float GetWidth()
    {
      return _width;
    }
    public float GetDepth()
    {
      return _depth;
    }
    public float GetWeight()
    {
      return _weight;
    }

    public void SetHeight(float height)
    {
      _height = height;
    }
    public void SetWidth(float width)
    {
      _width = width;
    }
    public void SetDepth(float depth)
    {
      _depth = depth;
    }
    public void SetWeight(float weight)
    {
      _weight = weight;
    }

    public float Volume()
    {
      return GetHeight() * GetWidth() * GetDepth();
    }
    public float CostToShip()
    {
      return Volume() * GetWeight();
    }


  }

}
