using Assets.Scripts.DataScripts;
using Assets.Scripts.Items;
using Reflex.Attributes;
using Reflex.Extensions;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.PlayerScripts
{
    public class Armory : MonoBehaviour
    {
        [SerializeField] private WeaponData _weaponData;
        [SerializeField] private string _newWeaponName;
        [SerializeField] private int _newWeaponAmmo;

        [Inject]
        IWeaponFactory _weaponFactory;

        private void Start()
        {
            var container = SceneManager.GetActiveScene().GetSceneContainer();
            IPlayer player = container.Resolve<IPlayer>();

            player.Equipment.AddItem(new Weapon(_weaponData.Name, _weaponData.Ammo));
            player.Equipment.AddItem(_weaponFactory.CreatePistol());
            player.Equipment.AddItem(_weaponFactory.CreateAnyWeapon(_newWeaponName, _newWeaponAmmo));
        }
    }
}