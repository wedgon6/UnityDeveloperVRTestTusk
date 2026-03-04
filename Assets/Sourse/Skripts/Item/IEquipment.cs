using System.Collections.Generic;

public interface IEquipment
{
    public IReadOnlyList<Item> Items { get; }
    public void AddItem(Item item);
}