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

        //if (SystemInfo.deviceType == DeviceType.Desktop)
        //{
        //    Debug.Log("Desktop Device");

        //    desktop.SetActive(true);
        //    mobile.SetActive(false);
        //    unknow.SetActive(false);
        //}
        
        //if(SystemInfo.deviceType == DeviceType.Handheld)
        //{
        //    Debug.Log("Método 1");

        //    desktop.SetActive(false);
        //    mobile.SetActive(true);
        //    unknow.SetActive(false);
        //}
        
        //if (Application.isMobilePlatform)
        //{
        //    Debug.Log("Método 2");

        //    desktop.SetActive(false);
        //    mobile.SetActive(true);
        //    unknow.SetActive(false);
        //}
        
        if (isMobile())
        {
            Debug.Log("Método 3");

            desktop.SetActive(false);
            mobile.SetActive(true);
            unknow.SetActive(false);
        }
    }
}
