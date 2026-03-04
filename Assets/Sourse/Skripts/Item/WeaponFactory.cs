public class WeaponFactory : IWeaponFactory
{
    public Weapon CreateAnyWeapon(string name, int ammo)
    {
        return new Weapon(name, ammo);
    }

    public Weapon CreatePistol()
    {
        return new Weapon("Pistol", 10);
    }
}