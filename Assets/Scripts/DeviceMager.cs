using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceMager : Singleton<DeviceMager>
{
    private AndroidJavaClass javaDev;
    private IntPtr classId;

    public override void Init()
    {
        javaDev = new AndroidJavaClass("com.example.hyz.devlib.Device");
        classId = javaDev.GetRawClass();
        //DevInit();
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
