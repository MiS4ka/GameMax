
namespace GameMax.Class;

public class Pos
{
    public int X { get; set; }
    public int Y { get; set; }
    public Pos(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public override string ToString()
    {
        return $"Pos(X: {X}, Y:{Y})";
    }
}
