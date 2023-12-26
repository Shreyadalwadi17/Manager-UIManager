using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButton : MonoBehaviour
{
    public Button s2;
    public Button s3;

    void Awake()
    {
        s2.onClick.AddListener(S2Btn);
        s3.onClick.AddListener(S3Btn);
    }
    public void S3Btn()
    {
        ScreenManager.inst.SwitchScreen(ScreenType.Screen3);
    }

    public void S2Btn()
    {
        ScreenManager.inst.SwitchScreen(ScreenType.Screen2);
    }

}

