using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDelegate1 : MonoBehaviour
{
    // string 타입 파라미터를 하나 가지고 있고 반환타입이 없는 delegate del을 선언.
    public delegate void Del(string str);

    public void StartBtn()
    {
        Del handler = DelegateMethod;
        handler("prac1");
    }

    void DelegateMethod(string str)
    {
        Debug.Log(str);
    }
}