using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessingController : MonoBehaviour
{
    protected int currentValue;
    public int MaxValue;

    protected float displayValue;

    public void UpdateValue(int plusValue)
    {
        if (currentValue + plusValue < 0)
        {
            currentValue = 0;
        }
        if (currentValue + plusValue > MaxValue)
        {
            currentValue = MaxValue;
        }
        currentValue +=plusValue;
    }

   protected virtual void Update()
    {
        displayValue = Mathf.Lerp(displayValue, currentValue, 0.1f);
        transform.localScale = new Vector3(
            displayValue / MaxValue,
            transform.localScale.y,
            transform.localScale.z
            );
    }
}
