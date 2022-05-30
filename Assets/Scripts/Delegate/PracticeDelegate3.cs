using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDelegate3 : MonoBehaviour
{
    // string Ÿ�� �Ķ���͸� �ϳ� ������ �ְ� ��ȯŸ���� ���� delegate del�� ����.
    public delegate void Del(string str);

    public void StartBtn()
    {
        Del handler = DelegateMethod1;
        handler += DelegateMethod2;
        handler += DelegateMethod3;

        handler("prac3");
    }

    void DelegateMethod1(string str)
    {
        Debug.Log(str + "-1");
    }

    void DelegateMethod2(string str)
    {
        Debug.Log(str + "-2");
    }

    void DelegateMethod3(string str)
    {
        Debug.Log(str + "-3");
    }
}