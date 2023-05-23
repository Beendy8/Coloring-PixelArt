using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;


public class ScreenShot : MonoBehaviour
{
    [DllImport("__Internal")]
    public static extern void BrowserTextDownload(string filename, string textContent);
    private IEnumerator ScrenShot()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();

        string name = "ScrenShot_EpicApp" + System.DateTime.Now.ToString("yyy-MM-dd_HH-mm-ss") + ".png";

        byte[] bytes = texture.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/../Screenshot.png" + name, bytes);
        Destroy(texture);
    }

    public void TakeScreenShot()
    {
        StartCoroutine("ScrenShot");
    }
}
