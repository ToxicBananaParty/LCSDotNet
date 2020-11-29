using LCSDotNet.Backend;

namespace LCSDotNet.Data
{
    public class Item
    {
        private ItemType type { get; }

        public Item(ItemType type)
        {
            this.type = type;
        }
    }
}