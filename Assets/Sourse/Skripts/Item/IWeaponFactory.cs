public interface IWeaponFactory
{
    public Weapon CreatePistol();
    public Weapon CreateAnyWeapon(string name, int ammo);
}