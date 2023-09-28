using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScreen : MonoBehaviour
{
    public GameObject blackOutSquare;

    void Update()
    {
        
    }

    public IEnumerator FadeBlackOutSquare(int fadeSpeed = 1)
    {
        Color objectColor = blackOutSquare.GetComponent<RawImage>().color;
        float fadeAmount;
            while (blackOutSquare.GetComponent<RawImage>().color.a < 1)
            {
                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor.a += fadeSpeed * Time.deltaTime;
                Debug.Log(objectColor);
                blackOutSquare.GetComponent<RawImage>().color = objectColor;
                yield return null;
            }
            yield return new WaitForSeconds(2.0f);
            while (blackOutSquare.GetComponent<RawImage>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<RawImage>().color = objectColor;
                yield return null;
            }
    }
}
