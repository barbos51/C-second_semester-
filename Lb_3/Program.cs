namespace Lb_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(5);
            BreakableWall wall = new BreakableWall(10);
            Bullet bullet = new Bullet(1);

            bullet.HitTarget(wall);
            bullet.HitTarget(enemy);
        }
    }
}
