using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnRayCast : MonoBehaviour
{
    delegate void TestDelegate();

    TestDelegate test;

    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D hit = Physics2D.Raycast(this.transform.position, Vector2.left, 1f);
        //Debug.DrawRay(this.transform.position, Vector2.left, Color.red, 1f);
        //if (hit.transform !=  null)
        //{
        //    Debug.Log(hit.transform.gameObject.name);
        //}
        test = Test;
        test();

    }
    void Test()
    {

    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("OnTriggerEnter " + collision.gameObject.name);
    //}

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    Debug.Log("OnTriggerStay " + collision.gameObject.name);
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    Debug.Log("OnTriggerExit " + collision.gameObject.name);
    //}
}
