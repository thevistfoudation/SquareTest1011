using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDamageInfo : ItemInfo
{
    public int Damage;
    public int TimeEffect;
}

public class ItemDamge : BaseItem
{

    public override void LoadItem()
    {
        info = (ItemInfo)DataController.Instance.itemVO.LoadItem<ItemDamageInfo>("ItemDamge");
        LoadUIItem(info);
    }

    protected override void ItemEffect(GameObject target)
    {
        //ItemDamageInfo itemDamgeInfo = (ItemDamageInfo)info;
        //ItemEffectDamge prevEffect = target.GetComponent<ItemEffectDamge>();
        //if (prevEffect != null)
        //{
        //    Destroy(prevEffect);
        //}
        //target.AddComponent<ItemEffectDamge>().AddDamge(itemDamgeInfo.Damage, itemDamgeInfo.TimeEffect);
    }
}
