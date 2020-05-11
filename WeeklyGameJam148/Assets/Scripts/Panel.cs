using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    public void TogglePanel(bool onOff)
    {
        panel.SetActive(onOff);
    }
}
