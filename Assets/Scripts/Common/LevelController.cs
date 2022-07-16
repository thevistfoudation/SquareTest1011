using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LevelController : ProcessingController
{
    public delegate void LevelUp(int level);

    public LevelUp levelUp;

    [SerializeField]
    TextMeshPro txtLevel;

    int level = 1;

    public int Level
    {
        get
        {
            return level;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        txtLevel.text = "Lv." + level.ToString();
        currentValue = 0;
    }

    public void SetLevel(int level)
    {
        this.level = level;
        UpdateLevel();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if(displayValue > MaxValue - 0.1f)
        {
            level++;
            
            currentValue = 0;
            UpdateLevel();
        }
    }

    void UpdateLevel()
    {
        txtLevel.text = "Lv." + level.ToString();
        if (levelUp != null)
        {
            levelUp(level);
        }
    }

}
