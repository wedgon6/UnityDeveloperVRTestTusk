public interface IPlayer
{
    public int Health { get; }
    public int Lives { get; }
    public string Nickname { get; }
    public Equipment Equipment { get; }
    public string[] Skills { get; }

    public void Initialize(
        int health,
        int levels,
        string nickname,
        string[] skills);
}