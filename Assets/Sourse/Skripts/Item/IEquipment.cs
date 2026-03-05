using System.Collections.Generic;

namespace Assets.Scripts.Items
{
    public interface IEquipment
    {
        public IReadOnlyList<Item> Items { get; }
        public void AddItem(Item item);
    }
}