using System.Collections;
using System.Collections.Generic;
using NatSuite.Sharing;
using UnityEngine;

public class TakeScreenshot : MonoBehaviour
{
    public GameObject canvas;

    public void TakeScreenShot()
    {
        Debug.Log("Screen Shot Taken");
        canvas.SetActive(false);
        StartCoroutine(TakeScreenshotAndSave());
    }
    private IEnumerator TakeScreenshotAndSave()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        var sharepayload = new SharePayload();
        sharepayload.AddImage(ss);
        sharepayload.Commit();

        Destroy(ss);

        canvas.SetActive(true);
    }
}
