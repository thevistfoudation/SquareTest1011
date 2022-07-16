using SimpleJSON;
using UnityEngine;

public class BaseVO
{
    protected JSONNode data;

    protected void  LoadData(string path)
    {
        Debug.Log("LoadData " + path);
        TextAsset textAsset = Resources.Load<TextAsset>(path);
        data = JSON.Parse(textAsset.text)["data"];
    }
    
}
