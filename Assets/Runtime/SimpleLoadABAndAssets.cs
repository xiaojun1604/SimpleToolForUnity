using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Object = UnityEngine.Object;

public class SimpleLoadABAndAssets : MonoBehaviour
{
    private string audioPath = string.Empty;
    
    // Start is called before the first frame update
    void Start()
    {
        audioPath = Application.dataPath + @"\..\StreamingAssets\";
        if (Directory.Exists(audioPath))
        {
            Debug.Log(audioPath);
        }
        else
        {
            Debug.LogError(audioPath);
        }

        audioPath = string.Concat(audioPath, "111.abc");
        if (File.Exists(audioPath))
        {
            Debug.Log(audioPath);
        }
        else
        {
            Debug.LogError(audioPath);
        }

        LoadAssets(audioPath);

    }

    void LoadAssets(string filepath)
    {
        AssetBundle ab = AssetBundle.LoadFromFile(filepath);
        Object[] objs = ab.LoadAllAssets();
        foreach (var obj in objs)
        {
            Type type = obj.GetType();
            Debug.Log(type);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
