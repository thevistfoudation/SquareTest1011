using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;
using TMPro;
public class TOPICNAME
{
    public const string ENEMYDESTROY = "EnemyDestroy";
    public const string ENDWAVE = "EndWave";
}

public class GameController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txtScore;
    int score;
    private void Awake()
    {
        DataController.Instance.LoadData();
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Observer.Instance.AddObserver(TOPICNAME.ENEMYDESTROY, OnEnemyDestroy);
    }

    void OnEnemyDestroy(object data)
    {
        score++;
        txtScore.text = score.ToString();
    }
}
