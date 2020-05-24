using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public InputField FirstHeap;
    public InputField SecondHeap;

    public Text text1;
    public Text text2;

    public GameObject layout;

    public void Close()
    {
        if ((FirstHeap.text.Length != 0) && (SecondHeap.text.Length!=0)&& (FirstHeap.text != "0") && (SecondHeap.text != "0"))
        {
            text1.text = FirstHeap.text;
            text2.text = SecondHeap.text;
            layout.gameObject.SetActive(false);
        }
    }
}
