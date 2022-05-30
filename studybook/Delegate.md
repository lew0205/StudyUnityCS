# Delegate의 특징
-delegate를 인스턴스화 하면 호환되는 파라미터 타입/개수와 반환 타입이 같은 모든 메소드를 참조할 수 있게 된다.
-한번 참조된 delegate 를 통해 참조된 함수를 대리로 호출하는 것이 가능하다. 

```C#
  public delegate void Del(string str);
  
  void Start()
  {
    string str = "delegate!";
    Del handler = Delmethod;
  
    handler(str);
  }
  
  void Delmethod(string str)
  {
    Debug.Log(str);
  }
```
