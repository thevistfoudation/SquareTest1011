using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
public class CreateController : MonoBehaviour
{
    [SerializeField]
    BulletController prefabBullet;

    [SerializeField]
    ExplosionController prefabExplosion;

    [SerializeField]
    EnemyController prefabEnemy;
        
    public BulletController createBullet(Transform tranShoot)
    {
        BulletController bullet = PoolingObject.createPooling<BulletController>(prefabBullet);
        if (bullet == null)
        {
            return Instantiate(prefabBullet, tranShoot.position, tranShoot.rotation);
        }
            bullet.time = 0;
            bullet.transform.position = tranShoot.position;
            bullet.transform.rotation = tranShoot.rotation;
            return bullet;
    }

    public ExplosionController createExplosion(Vector3 pos)
    {
       return Instantiate(prefabExplosion, pos, prefabExplosion.transform.rotation);
    }
    public EnemyController createEnemy(Vector3 pos)
    {
        return Instantiate(prefabEnemy, pos, prefabEnemy.transform.rotation);
    }
}

public class Creater : SingletonMonoBehaviour<CreateController>
{

}