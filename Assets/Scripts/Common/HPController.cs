using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPController : ProcessingController
{
    public delegate void Die();

    public Die die;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        currentValue = MaxValue;
        displayValue = currentValue;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.green;
    }

    public void UpdateHP(int HP)
    {
        MaxValue += HP;
        ResetHP();
    }

    public void ResetHP()
    {
        currentValue = MaxValue;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (displayValue < MaxValue - 0.1f)
        {
            spriteRenderer.color = Color.Lerp(Color.red, Color.yellow,displayValue/MaxValue);
        }
        else
        {
            spriteRenderer.color = Color.green;
        }
        if (displayValue < 0.1f)
        {
            if (die != null)
            {
                die();
            }
        }
    }
}
