using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
[System.Serializable]
public class Stage
{
    public Wave[] waves;
}
public class StageController : MonoBehaviour
{
    [SerializeField]
    Stage[] stages;
    int currentIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentIndex = 0;
        createStage();
        Observer.Instance.AddObserver(TOPICNAME.ENDWAVE, OnEndWave);
    }
    void OnEndWave(object data)
    {
        currentIndex++;
        createStage();
    }
    void createStage()
    {
        if (currentIndex >= stages.Length)
        {
            Debug.Log("You Win");
            return;
        }
        Stage currentStage = stages[currentIndex];
        Waves.Instance.Waves = currentStage.waves;
        Waves.Instance.createWave();
    }
}
