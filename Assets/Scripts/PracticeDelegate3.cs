using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeDelegate3 : MonoBehaviour
{
    // string Ÿ�� �Ķ���͸� �ϳ� ������ �ְ� ��ȯŸ���� ���� delegate del�� ����.
    public delegate void Del(string str);

    public void StartBtn()
    {
        Del handler = DelegateMethod;
    }

    void DelegateMethod(string str)
    {
        Debug.Log(str);
    }
}