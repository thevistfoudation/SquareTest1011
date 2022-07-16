using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
public class LearnUnity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextAsset textAsset = Resources.Load<TextAsset>("Data/Player");
        Debug.Log(textAsset.text);
        JSONNode json =  JSON.Parse(textAsset.text);
        JSONArray array = json["data"].AsArray;
        Debug.Log(array[0]["hp"].AsInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
