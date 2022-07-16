using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TankController : MoveController,IHit
{
    //[SerializeField]
    Transform Gun;

    //[SerializeField]
    protected Transform Than;

    //[SerializeField]
    Transform tranShoot;

    //[SerializeField]
    HPController hpController;

    [HideInInspector]
    public LevelController levelController;

    [SerializeField]
    int damage;

    protected virtual void Awake()
    {
        Than = transform.Find("Than");
        Gun = transform.Find("Gun");
        tranShoot = Gun.Find("Barrel").Find("tranShoot");
        hpController = transform.Find("HPController").GetComponent<HPController>();
        levelController = transform.Find("LevelController").GetComponent<LevelController>();
        hpController.die = onDestroy;
        levelController.levelUp = OnLevelUp;
    }

    protected override void Move(Vector3 direction)
    {
        if (direction != Vector3.zero)
        {
            Than.up = direction;
        }
        base.Move(direction);
    }

    protected void RotateGun(Vector3 direction)
    {
        Gun.up = direction;
    }

    public void Shoot()
    {
        BulletController bullet = Creater.Instance.createBullet(tranShoot);
        bullet.damage = damage;
        bullet.tag = this.tag;
    }

    public void OnHit(int damage)
    {
        hpController.UpdateValue(-damage);
    }

    protected abstract void onDestroy();

    protected abstract void OnLevelUp(int level);

    protected virtual void UpdateTank(TankInfo tankInfo)
    {
        hpController.UpdateHP(tankInfo.hp);
        damage = tankInfo.damage;
    }
}
