using Reflex.Core;
using UnityEngine;

public class ProgramInstaller : MonoBehaviour, IInstaller
{
    private IPlayer _player;
    private IWeaponFactory _weaponFactory;

    public void InstallBindings(ContainerBuilder containerBuilder)
    {
        //_player = new Player();
        _weaponFactory = new WeaponFactory();
        //containerBuilder.AddSingleton(_player, typeof(IPlayer));
        containerBuilder.AddSingleton(_weaponFactory, typeof(IWeaponFactory));
    }
}