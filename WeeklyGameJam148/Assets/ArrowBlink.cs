using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowBlink : MonoBehaviour
{
    public Renderer arrowRender;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Blink");
    }

    IEnumerator Blink()
    {
        yield return new WaitForSeconds(0.5f);
        arrowRender.enabled = false;
        yield return new WaitForSeconds(0.5f);
        arrowRender.enabled = true;
        StartCoroutine("Blink");
    }
}
