using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPowerInfo : ItemInfo
{
    public int Speed;
    public int Damage;
    public int HPPlus;
    public int TimeEffect;
}
public class ItemPower : BaseItem
{
    public override void LoadItem()
    {
        info = (ItemInfo)DataController.Instance.itemVO.LoadItem<ItemPowerInfo>("ItemPower");
        LoadUIItem(info);

    }

    protected override void ItemEffect(GameObject target)
    {
        //ItemPowerInfo itemPowerInfo = (ItemPowerInfo)info;
        //ItemEffectDamge prevDEffect = target.GetComponent<ItemEffectDamge>();
        //if (prevDEffect != null)
        //{
        //    Destroy(prevDEffect);
        //}
        //ItemEffectSpeed prevSEffect = target.GetComponent<ItemEffectSpeed>();
        //if (prevSEffect != null)
        //{
        //    Destroy(prevSEffect);
        //}
        //target.AddComponent<ItemEffectDamge>().AddDamge(itemPowerInfo.Damage, itemPowerInfo.TimeEffect);
        //target.AddComponent<ItemEffectHP>().PlusHP(itemPowerInfo.HPPlus);
        //target.AddComponent<ItemEffectSpeed>().AddSpeed(itemPowerInfo.Speed, itemPowerInfo.TimeEffect);
    }
}