namespace Assets.Scripts.Items
{
    public abstract class Item
    {
        private string _name;

        public Item(string name)
        {
            _name = name;
        }

        public string Name => _name;
    }
}