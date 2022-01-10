namespace ConsoleUI;
public class Vec2
{
    public float x;
    public float y;
    public Vec2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }
    public static Vec2 operator +(Vec2 a, Vec2 b)
    => new (a.x + b.x, a.y + b.y);
    public override string ToString() => $"{x}, {y}";
}


