using Assets.Scripts.Items;
using Assets.Scripts.PlayerScripts;
using Reflex.Core;
using UnityEngine;

namespace Assets.Scripts.DIReflex
{
    public class ProgramInstaller : MonoBehaviour, IInstaller
    {
        private IPlayer _player;
        private IWeaponFactory _weaponFactory;

        public void InstallBindings(ContainerBuilder containerBuilder)
        {
            _player = new Player();
            _weaponFactory = new WeaponFactory();
            containerBuilder.AddSingleton(_player, typeof(IPlayer));
            containerBuilder.AddSingleton(_weaponFactory, typeof(IWeaponFactory));
        }
    }
}