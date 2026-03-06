using UnityEngine;

namespace Assets.Scripts.DataScripts
{
    [CreateAssetMenu(fileName = "ChargeItemData", menuName = "CreateItem/RocketPack", order = 51)]
    public class ChargeItemData : BaseItemData
    {
        [SerializeField] private int _charges;

        public int Charges => _charges;
    }
}