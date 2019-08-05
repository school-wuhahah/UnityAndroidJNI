using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DeviceMager : Singleton<DeviceMager>
{
    private AndroidJavaClass javaDev;
    private IntPtr classId;

    private delegate string RtnStrDelegate();
    private delegate int RtnIntDelegate();

    public override void Init()
    {
        javaDev = new AndroidJavaClass("com.example.hyz.devlib.Device");
        classId = javaDev.GetRawClass();
        //DevInit();
        RtnStrDelegate cbvn = GetVersionName;
        IntPtr cbvn_ptr = Marshal.GetFunctionPointerForDelegate(cbvn);
        CppInterface.SetVersionNamePtr(cbvn_ptr);

        RtnIntDelegate cbvc = GetVersionCode;
        IntPtr cbvc_ptr = Marshal.GetFunctionPointerForDelegate(cbvc);
        CppInterface.SetVersionCodePtr(cbvc_ptr);

        RtnStrDelegate cban = GetAppName;
        IntPtr cban_ptr = Marshal.GetFunctionPointerForDelegate(cban);
        CppInterface.SetAppNamePtr(cban_ptr);
    }

    //private void DevInit()
    //{
    //    Debug.Log("DevInit bgn ...");
    //    AndroidJavaClass unityActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    //    AndroidJavaObject mContext = unityActivity.GetStatic<AndroidJavaObject>("currentActivity");
    //    IntPtr methodid = AndroidJNIHelper.GetMethodID(classId, "onCreate", "(Ljava/lang/Object;)V", true);
    //    if (methodid != IntPtr.Zero)
    //    {
    //        AndroidJNI.CallStaticVoidMethod(classId, methodid, null);
    //        Debug.Log("DevInit callfunc ...");
    //    }
    //    Debug.Log("DevInit end ...");
    //}

    public string GetVersionName()
    {
        IntPtr methodid = AndroidJNIHelper.GetMethodID(classId, "getVersionName", "()Ljava/lang/String", true);
        if (methodid != IntPtr.Zero)
        {
            string ret = AndroidJNI.CallStaticStringMethod(classId, methodid, null);
            return ret;
        }
        return "";
    }

    public int GetVersionCode()
    {
        IntPtr methodid = AndroidJNIHelper.GetMethodID(classId, "getVersionCode", "()I", true);
        if (methodid != IntPtr.Zero)
        {
            int ret = AndroidJNI.CallStaticIntMethod(classId, methodid, null);
            return ret;
        }
        return 0;
    }

    public string GetAppName()
    {
        IntPtr methodid = AndroidJNIHelper.GetMethodID(classId, "getAppName", "()Ljava/lang/String", true);
        if (methodid != IntPtr.Zero)
        {
            string ret = AndroidJNI.CallStaticStringMethod(classId, methodid, null);
            return ret;
        }
        return "";
    }

    public override void Dispose()
    {
       
    }
}
