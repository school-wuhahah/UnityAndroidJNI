using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class TestDev : MonoBehaviour
{
    public Text vnTxt;
    public Text vcTxt;
    public Text anTxt;

    private delegate void DebugDelegate(IntPtr strPtr);


    // Start is called before the first frame update
    void Start()
    {
        RegisterDebugCallback();
        Debug.Log("TestDev bgn ...");
#if UNITY_ANDROID
        vnTxt.text = DeviceMager.instance.GetVersionName();
        vcTxt.text = DeviceMager.instance.GetVersionCode().ToString();
        anTxt.text = DeviceMager.instance.GetAppName();
#endif
        //DeviceMager.instance.GetVersionName();
        Debug.Log("TestDev end ...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RegisterDebugCallback()
    {
        DebugDelegate cb = CallBackFunction;
        IntPtr intptr_delegate = Marshal.GetFunctionPointerForDelegate(cb);
        CppInterface.SetDebugFuncPtr(intptr_delegate);
    }

    static void CallBackFunction(IntPtr strPtr)
    {
        Debug.Log("CppLog: " + Marshal.PtrToStringAnsi(strPtr));
    }
}
