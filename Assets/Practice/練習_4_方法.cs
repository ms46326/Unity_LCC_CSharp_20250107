using UnityEngine;

public class 練習_4_方法 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log(bool1());
        Debug.Log(bool2());
    }

    private bool bool1()
    {
        return true && true;
        
    }
    private bool bool2()
    {
        return false || false;
        
    }
}
