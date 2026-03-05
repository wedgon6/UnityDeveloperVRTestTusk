using UnityEngine;

namespace Assets.Scripts.DataScripts
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "CreateItem", order = 51)]
    public class BaseItemData : ScriptableObject
    {
        [SerializeField] private string _name;

        public string Name => _name;
    }
}