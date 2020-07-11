
using UnityEngine;

public class scrInventoryManager : MonoBehaviour
{
    [SerializeField] scrInventory inventory;
    [SerializeField] scrEquipmentPanel equipmentPanel;

    public void EquipItem(scrEquippableItem item)
    {
        if (inventory.RemoveItem(item))
        {
            scrEquippableItem previousItem;
            if (equipmentPanel.AddItem(item, out previousItem))
            {
                if (previousItem != null)
                    inventory.AddItem(previousItem);
            }
            else inventory.AddItem(item);
        }
    }

    public void UnequipItem(scrEquippableItem item)
    {
        if (!inventory.IsFull() && equipmentPanel.RemoveItem(item))
            inventory.AddItem(item);
    }
}
