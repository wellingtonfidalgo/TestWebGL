using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class TestDevice : MonoBehaviour
{
    [SerializeField] private GameObject desktop;
    [SerializeField] private GameObject mobile;
    [SerializeField] private GameObject unknow;

    // Start is called before the first frame update
    void Start()
    {
        if (Application.isMobilePlatform)
        {
            desktop.SetActive(false);
            mobile.SetActive(true);
            unknow.SetActive(false);
        }
        else
        {
            desktop.SetActive(true);
            mobile.SetActive(false);
            unknow.SetActive(false);
        }
    }
}
