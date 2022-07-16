using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
[System.Serializable]
public class Wave
{
    public int numEnemy;
    public int lvEnemy;
}


public class WaveController : MonoBehaviour
{
    [SerializeField]
    Wave[] waves;
    public Wave[] Waves
    {
        set
        {
            waves = value;
            currentIndex = 0;
        }
    }
    int currentIndex;
    int numEnemy;
    // Start is called before the first frame update
    void Start()
    {
        currentIndex = 0;
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, OnEnemyDestroy);
    }

    void OnEnemyDestroy(object data)
    {
        numEnemy--;
        if (numEnemy <= 0)
        {
            currentIndex++;
            createWave();
        }
    }
    public void createWave()
    {
        if (currentIndex >= waves.Length)
        {
            Observer.Instance.Notify(TOPICNAME.ENDWAVE);
            return;
        }
        Wave currentWave = waves[currentIndex];
        numEnemy = currentWave.numEnemy;
        Vector3 playerPos = Player.Instance.transform.position;
        for (int i = 0; i < numEnemy; i++)
        {
            Vector3 enemyPos = new Vector3(
                playerPos.x + Random.Range(-10f, 10f),
                playerPos.y + Random.Range(-10f, 10f)
                );
            EnemyController enemy = Creater.Instance.createEnemy(enemyPos);
            enemy.levelController.SetLevel(currentWave.lvEnemy);
        }
    }
}

public class Waves : SingletonMonoBehaviour<WaveController>
{

}