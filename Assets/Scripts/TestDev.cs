using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestDev : MonoBehaviour
{
    public Text vnTxt;
    public Text vcTxt;
    public Text anTxt;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TestDev bgn ...");
#if UNITY_ANDROID
        vnTxt.text = DeviceMager.instance.GetVersionName();
        vcTxt.text = DeviceMager.instance.GetVersionCode().ToString();
        anTxt.text = DeviceMager.instance.GetAppName();
#endif
        Debug.Log("TestDev end ...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
