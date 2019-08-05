using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class CppInterface : MonoBehaviour
{
    [DllImport("libCppInterface",EntryPoint = "setDebugFuncPtr")]
    public extern static void SetDebugFuncPtr(IntPtr ptr);

    [DllImport("libCppInterface", EntryPoint = "set_versionNamePtr")]
    public extern static void SetVersionNamePtr(IntPtr ptr);

    [DllImport("libCppInterface", EntryPoint = "set_versionCodePtr")]
    public extern static void SetVersionCodePtr(IntPtr ptr);

    [DllImport("libCppInterface", EntryPoint = "set_appNamePtr")]
    public extern static void SetAppNamePtr(IntPtr ptr);

    
}
