using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpeedInfo : ItemInfo
{
    public int Speed;
    public int TimeEffect;
}

public class ItemSpeed : BaseItem
{
    public override void LoadItem()
    {
        info = (ItemInfo)DataController.Instance.itemVO.LoadItem<ItemSpeedInfo>("ItemSpeed");
        LoadUIItem(info);

    }

    protected override void ItemEffect(GameObject target)
    {
        //ItemSpeedInfo itemSpeedInfo = (ItemSpeedInfo)info;
        //ItemEffectSpeed prevEffect = target.GetComponent<ItemEffectSpeed>();
        //if (prevEffect != null)
        //{
        //    Destroy(prevEffect);
        //}
        //target.AddComponent<ItemEffectSpeed>().AddSpeed(itemSpeedInfo.Speed, itemSpeedInfo.TimeEffect);
    }
}
