using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class TestDevice : MonoBehaviour
{
    [SerializeField] private GameObject desktop;
    [SerializeField] private GameObject mobile;
    [SerializeField] private GameObject unknow;

    [DllImport("__Internal")]
    private static extern bool IsMobile();

    public bool isMobile()
    {
        #if !UNITY_EDITOR && UNITY_WEBGL
            return IsMobile();
        #endif
        return false;
    }

    // Start is called before the first frame update
    void Start()
    { 

        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            desktop.SetActive(true);
            mobile.SetActive(false);
            unknow.SetActive(false);
        }else if(SystemInfo.deviceType == DeviceType.Handheld)
        {
            Debug.Log("Método 1");

            desktop.SetActive(false);
            mobile.SetActive(true);
            unknow.SetActive(false);
        }else if (Application.isMobilePlatform)
        {
            Debug.Log("Método 2");

            desktop.SetActive(false);
            mobile.SetActive(true);
            unknow.SetActive(false);
        }else if (IsMobile())
        {
            Debug.Log("Método 3");

            desktop.SetActive(false);
            mobile.SetActive(true);
            unknow.SetActive(false);
        }
        else
        {
            desktop.SetActive(false);
            mobile.SetActive(false);
            unknow.SetActive(true);
        }
    }
}
