using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "CreateItem/Weapon", order = 51)]
public class WeaponData : BaseItemData
{
    [SerializeField] private int _ammo;

    public int Ammo => _ammo;
}