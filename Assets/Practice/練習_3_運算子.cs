using UnityEngine;

public class 練習_3_運算子 : MonoBehaviour
{
    private void Awake()
    {
        FirstFunction();
        FirstFunction2();
    }

    
    private void FirstFunction( float num1 = 6 , float num2 = 2 , float num3= 1 , float num4 = 2)
    {
        Debug.Log($"<color=#f93> {num1} / {num2} ( {num3} + {num4} ) = {num1 / num2*(num3+num4)}</color>");

    }
    
    private void FirstFunction2()
    {
        Debug.Log(6 / 2*(1 + 2));
    }
}
