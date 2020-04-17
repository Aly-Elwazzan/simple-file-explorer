using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class FileManager : MonoBehaviour
{
    string path;
    public RawImage Image;

    public  void OpenExplorer ()
    {
        path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
        GetImage();
    }

    void GetImage()
    {
        if (path!=null)

        {
            UpdateImage();
        }   
    
    }

    void UpdateImage()
    {
        WWW www = new WWW("file:///" + path);
        Image.texture = www.texture;
    }
}
