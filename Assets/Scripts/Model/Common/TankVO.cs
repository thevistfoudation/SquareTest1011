using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class TankInfo
{
    public int hp;
    public int damage;
    public string UIPathThan;
}
public class TankVO : BaseVO
{
    public TankInfo LoadTankInfo(int level)
    {
        JSONArray json = data.AsArray;
        Debug.Log(json == null);
        if (level >= json.Count)
        {
            return JsonUtility.FromJson<TankInfo>(json[json.Count - 1].ToString());
        }
        return JsonUtility.FromJson<TankInfo>(json[level - 1].ToString());
    }
}
