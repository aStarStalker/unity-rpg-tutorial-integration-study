using System.Collections.Generic;
using UnityEngine;

public class scrInventory : MonoBehaviour
{
    [SerializeField] List <scrItem> items;
    [SerializeField] Transform itemsParent;
    [SerializeField] scrItemSlots[] itemSlots;

    private void OnValidate()
    {
        if (itemsParent != null)
            itemSlots = itemsParent.GetComponentsInChildren<scrItemSlots>();

        RefreshUI();
    }

    private void RefreshUI()
    {
        int i = 0;
        for (; i < items.Count && i < itemSlots.Length; i++)
        {
            itemSlots[i].Item = items[i];
        }
        for (; i < itemSlots.Length; i++)
        {
            itemSlots[i].Item = null;
        }
    }
}
