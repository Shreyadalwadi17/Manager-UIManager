using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ScreenType
{
    Screen1,
    Screen2,
    Screen3

}

public class BaseScreen : MonoBehaviour
{
    //Multiple Screen Number
    public ScreenType screenType;
    //Perticular canvas
    public Canvas canvas;


    public void Awake()
    {
        canvas = GetComponent<Canvas>();
    }
}
