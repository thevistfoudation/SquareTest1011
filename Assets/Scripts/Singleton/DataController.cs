using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class DataController : Singleton<DataController>
{
    public PlayerVO playerVO;

    public EnemyVO enemyVO;

    public ItemVO itemVO;

    public void LoadData()
    {
        playerVO = new PlayerVO();
        enemyVO = new EnemyVO();
        itemVO = new ItemVO();
    }
}
