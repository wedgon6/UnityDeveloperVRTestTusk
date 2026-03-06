using UnityEngine;

namespace Assets.Scripts.DataScripts
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "CreatePlayerData", order = 51)]
    public class PlayerData : ScriptableObject
    {
        [SerializeField] private int _baseHealth;
        [SerializeField] private int _baseLives;
        [SerializeField] private string _baseNickname;
        [SerializeField] private string[] _baseSkills;

        public int BaseHealth => _baseHealth;
        public int BaseLives => _baseLives;
        public string baseNickname => _baseNickname;
        public string[] BaseSkills => _baseSkills;
    }
}