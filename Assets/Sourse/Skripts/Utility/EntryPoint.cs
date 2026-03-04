using Reflex.Attributes;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private ParachuteData _parachuteData;
    [SerializeField] private RocketPackData _rocketPackData;

    [Inject]
    private IPlayer _player;

    private void Start()
    {
        _player.Initialize(
            _playerData.BaseHealth,
            _playerData.BaseLives,
            _playerData.baseNickname,
            _playerData.BaseSkills);

        _player.Equipment.AddItem(new Parachute(_parachuteData.Name));
        _player.Equipment.AddItem(new RocketPack(_rocketPackData.Name, _rocketPackData.Charges));
    }
}