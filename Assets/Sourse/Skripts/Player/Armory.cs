using Reflex.Attributes;
using Reflex.Extensions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Armory : MonoBehaviour
{
    [SerializeField] private WeaponData _weaponData;
    [SerializeField] private string _newWeaponName;
    [SerializeField] private int _newWeaponAmmo;

    [Inject]
    IWeaponFactory _weaponFactory;

    [Inject]
    IPlayer _player;

    private void Start()
    {
        var container = SceneManager.GetActiveScene().GetSceneContainer();
        IPlayer player = container.Resolve<IPlayer>();

        _player.Equipment.AddItem(new Weapon(_weaponData.Name, _weaponData.Ammo));
        _player.Equipment.AddItem(_weaponFactory.CreatePistol());
        _player.Equipment.AddItem(_weaponFactory.CreateAnyWeapon(_newWeaponName, _newWeaponAmmo));
    }
}