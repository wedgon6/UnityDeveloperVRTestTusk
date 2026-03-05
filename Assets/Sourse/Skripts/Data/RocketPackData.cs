using UnityEngine;

namespace Assets.Scripts.DataScripts
{
    [CreateAssetMenu(fileName = "RocketPackData", menuName = "CreateItem/RocketPack", order = 51)]
    public class RocketPackData : BaseItemData
    {
        [SerializeField] private int _charges;

        public int Charges => _charges;
    }
}