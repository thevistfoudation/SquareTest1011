using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class PlayerController : TankController
{
    void Start()
    {
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, OnEnemyDestroy);
    }

    protected override void onDestroy()
    {
       
    }

    void OnEnemyDestroy(object data)
    {
        int levelEnemy = (int)data;
        levelController.UpdateValue(10*levelEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);
        Move(direction);
        ItemFactory.CheckItem(this.transform);
        Vector3 gunDirection = new Vector3(     
                Input.mousePosition.x - Screen.width / 2,
                Input.mousePosition.y - Screen.height/ 2
            );
        RotateGun(gunDirection);
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    private void OnDestroy()
    {
        Observer.Instance.RemoveObserver(TOPICNAME.ENEMYDESTROY, OnEnemyDestroy);
    }

    protected override void OnLevelUp(int level)
    {
        TankInfo tankInfo = DataController.Instance.playerVO.LoadTankInfo(level);
        UpdateTank(tankInfo);
    }

    protected override void UpdateTank(TankInfo tankInfo)
    {
        base.UpdateTank(tankInfo);
        Than.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(tankInfo.UIPathThan);
    }
}

public class Player : SingletonMonoBehaviour<PlayerController>
{

}