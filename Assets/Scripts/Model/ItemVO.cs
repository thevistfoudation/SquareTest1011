using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo
{
    public string UIPath;
}

public class ItemVO : BaseVO
{
    public ItemVO()
    {
        LoadData("Data/Items");
    }

    public T LoadItem<T>(string TypeItem) where T : ItemInfo
    {
        return JsonUtility.FromJson<T>(data[TypeItem].ToString());
    }
}
