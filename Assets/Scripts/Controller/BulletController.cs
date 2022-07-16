using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class BulletController : MoveController
{
    public int time = 0;

    public int damage;

    // Update is called once per frame
    void Update()
    {
        if (time == 20)
        {
            Creater.Instance.createExplosion(transform.position);
            PoolingObject.DestroyPooling<BulletController>(this);
            return;
        }
        time++;
        Move(transform.up);
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position,transform.up, 0.25f);
        if (hit.transform != null)
        {
            PoolingObject.DestroyPooling<BulletController>(this);
            if (hit.transform.tag == "Tree")
            {
                Creater.Instance.createExplosion(transform.position);
                PoolingObject.DestroyPooling<BulletController>(this);
            }
            if (hit.transform.tag == this.tag) return;
            IHit Onhit = hit.transform.GetComponent<IHit>();
            if (Onhit != null)
            {
                Onhit.OnHit(damage);
            }
        }

    }
}
