using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class JsonPlacer1 : MonoBehaviour
{
    public string text;
    public string oku;
    public static Jason1 json;
    void Start()
    {
        string js = File.ReadAllText(Application.dataPath + "/save.pelit");
        print(js);
        
        
           
            if (JsonUtility.FromJson<Jason1>(js) != null)
            {
                json = JsonUtility.FromJson<Jason1>(js);
                Debug.Log("selam");
            }
            else
            {
                
                json = new Jason1("0");
                Debug.Log("merhaba");
            }
            
            
        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnApplicationQuit(){
        string js = JsonUtility.ToJson(json);
        print(js);
        File.WriteAllText(Application.dataPath + "/save.pelit", js);
        print("quit!");
    }
}
