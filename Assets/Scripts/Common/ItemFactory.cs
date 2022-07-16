using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class ItemFactory : MonoBehaviour
{
    public GameObject prefabItem;

    public static List<BaseItem> listItems = new List<BaseItem>();

    public static void CheckItem(Transform target)
    {
        foreach (BaseItem item in listItems)
        {
            if (Vector3.Distance(target.position, item.transform.position) < 2f)
            {
                item.setTarget(target);
                listItems.Remove(item);
                break;
            }
        }
    }



    public BaseItem Create(int index, Vector3 pos)
    {
        switch (index)
        {
            case 0:
                return createItem<ItemHP>(pos);
            case 1:
                return createItem<ItemDamge>(pos);
            case 2:
                return createItem<ItemSpeed>(pos);
            case 3:
                return createItem<ItemPower>(pos);
        }

        return null;
    }

    T createItem<T>(Vector3 pos) where T : BaseItem
    {
        T item = Instantiate(prefabItem, pos, prefabItem.transform.rotation).AddComponent<T>();
        item.LoadItem();
        listItems.Add(item);
        return item;

    }

}
public class Items : SingletonMonoBehaviour<ItemFactory>
{

}