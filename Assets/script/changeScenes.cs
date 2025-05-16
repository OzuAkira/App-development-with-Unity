using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeScenes : MonoBehaviour
{
    public Button button_1,button_2;
    private void Start()
    {
        button_1.onClick.AddListener(b_1);
        button_2.onClick.AddListener(b_2);
    }
    void b_1()
    {
        Debug.Log("aaa");
    }
    void b_2()
    {
        Debug.Log("bbb");
    }

}
