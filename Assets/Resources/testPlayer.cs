using Reflex.Core;
using UnityEngine;

public class testPlayer : MonoBehaviour, IInstaller
{
    private IPlayer _player;
    public void InstallBindings(ContainerBuilder containerBuilder)
    {
        _player = new Player();
        containerBuilder.AddSingleton(_player, typeof(IPlayer));
    }
}