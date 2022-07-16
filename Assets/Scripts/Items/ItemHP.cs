using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHPInfo : ItemInfo
{
        public int HPPlus;
}
public class ItemHP : BaseItem
    {
        public override void LoadItem()
        {
            info = (ItemInfo)DataController.Instance.itemVO.LoadItem<ItemHPInfo>("ItemHP");
            LoadUIItem(info);

        }

        protected override void ItemEffect(GameObject target)
        {
            //ItemHPInfo itemHPInfo = (ItemHPInfo)info;
            //target.AddComponent<ItemEffectHP>().PlusHP(itemHPInfo.HPPlus);
        }
    }
