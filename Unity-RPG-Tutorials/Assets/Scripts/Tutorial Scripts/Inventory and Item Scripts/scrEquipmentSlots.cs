
public class scrEquipmentSlots : scrItemSlots
{
    public EquipmentType EquipmentType;

    protected virtual void OnValidate()
    {
        base.OnValidate();
        gameObject.name = EquipmentType.ToString() + " Slot";
    }
}
