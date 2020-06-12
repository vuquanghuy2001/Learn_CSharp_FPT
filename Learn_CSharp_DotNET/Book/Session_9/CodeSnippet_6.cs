namespace Learn_CSharp_DotNET.Book.Session_9
{
    public abstract class Figure
    {
        public abstract float DimensionOne
        {
            set;
        }
        public abstract float DimensionTwo
        {
            set;
        }
    }
    class Rectangle : Figure
    {
        float _dimensionOne;
        float _dimensionTwo;
        public override float DimensionOne
        {
            set
            {
                if (value <= 0)
                {
                    _dimensionOne = 0;
                }
                else
                {
                    _dimensionOne = value;
                }
            }
        }
        public override float DimensionTwo
        {
            set
            {
                if (value <= 0)
                {
                    _dimensionTwo = 0;
                }
                else
                {
                    _dimensionTwo = value;
                }
            }
        }
        float Area()
        {
            return _dimensionOne * _dimensionTwo;
        }
    }
}