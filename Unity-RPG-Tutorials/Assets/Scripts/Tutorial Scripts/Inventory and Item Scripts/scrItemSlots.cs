using UnityEngine;
using UnityEngine.UI;

public class scrItemSlots : MonoBehaviour
{
    [SerializeField] Image itemImage;

    private scrItem _item;
    public scrItem Item {
        get { return _item; }
        set { _item = value;
                if (_item == null)
                    itemImage.enabled = false;
                else
                {
                    itemImage.sprite = _item.ItemIcon;
                    itemImage.enabled = true;
                }
            }
    }

    protected virtual void OnValidate()
    {
        if (itemImage == null)
            itemImage = GetComponent<Image>();
    }
}


