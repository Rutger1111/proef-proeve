using System.Data;
using UnityEngine;
using System;
using System.IO;
using System.Diagnostics;
using SFB;

public class ScreenShot : MonoBehaviour
{
    private string savePath;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            
            string[] paths = StandaloneFileBrowser.OpenFolderPanel("Choose Save Location", "", false);
            if (paths.Length > 0)
            {
                savePath = paths[0];
                string filePath = savePath + "/screenshot-" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + ".png";
                ScreenCapture.CaptureScreenshot(filePath, 4);
                print("Screenshot saved at: " + filePath);
            }
        }
    }

}
