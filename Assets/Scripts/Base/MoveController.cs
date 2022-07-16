using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveController : MonoBehaviour
{
    [SerializeField]
    float speed;

    protected virtual void Move(Vector3 direction)
    {
        this.transform.position += direction * Time.deltaTime*speed;
    }
}
