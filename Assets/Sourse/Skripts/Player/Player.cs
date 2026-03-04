using UnityEngine;

public class Player : IPlayer
{
    public int Health { get; private set; }
    public int Lives { get; private set; }
    public string Nickname { get; private set; }
    public string[] Skills { get; private set; }
    public Equipment Equipment { get; private set; } = new Equipment();

    public Player()
    {
        // Equipment = new();
        Debug.Log("NEW PLAYER");
    }

    public void Initialize(
        int health,
        int levels,
        string nickname,
        string[] skills)
    {
        Health = health;
        Lives = levels;
        Nickname = nickname;
        Skills = skills;
        Equipment = new();
    }
}