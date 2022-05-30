using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDelegate2 : MonoBehaviour
{
    // string Ÿ�� �Ķ���͸� �ϳ� ������ �ְ� ��ȯŸ���� ���� delegate del�� ����.
    public delegate void Del(string str);

    public void StartBtn()
    {
        Del handler = DelegateMethod;

        RunHeavyJob(handler);
    }

    void RunHeavyJob(Del handler)
    {
        string result = "prac2";

        handler(result);
    }

    void DelegateMethod(string str)
    {
        Debug.Log(str);
    }
}