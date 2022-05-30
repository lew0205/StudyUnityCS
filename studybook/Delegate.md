# Delegate의 특징
-delegate를 인스턴스화 하면 호환되는 파라미터 타입/개수와 반환 타입이 같은 모든 메소드를 참조할 수 있게 된다.
-한번 참조된 delegate 를 통해 참조된 함수를 대리로 호출하는 것이 가능하다. 

예시 코드
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
결과 : delegate!

```C#
public delegate void Del(string str);

void Start()
{
string str = "delegate!";
Del handler = Delmethod1;
handelr += Delmethod2;
handler += Delmethod3;

handler(str);
}

void Delmethod1(string str)
{
Debug.Log(str+"1");
}

void Delmethod2(string str)
{
Debug.Log(str+"2");
}

void Delmethod3(string str)
{
Debug.Log(str+"3");
}
```
결과 : 
delegate!1
delegate!2
delegate!3

에셋 분석하다가 이해가 안돼서 공부하게 됐는데 꽤 유용하게 사용할 수 있을것 같다.
