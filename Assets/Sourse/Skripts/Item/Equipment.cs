using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Items
{
    public class Equipment : IEquipment
    {
        private List<Item> _items = new();

        public IReadOnlyList<Item> Items => _items;

        public void AddItem(Item item)
        {
            _items.Add(item);
            Debug.Log($"Кол-во предметов{_items.Count}. Добавен {item.Name}");
        }
    }
}