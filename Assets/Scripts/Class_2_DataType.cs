using UnityEngine;
//三條斜線是摘要 <XML 語言>用來做簡短說明，可加在類別與變數上方
/// <summary>
/// 認識資料類型
/// </summary>

public class Class_2_DataType : MonoBehaviour 
{
    //變數語法：
    //修飾詞 變數資料類型 變數名稱 指定 預設值;
    //四大常用資料類型
    //整數：
    //浮點數：
    //字串：
    //布林值：
    public int count = 7;
    public float moveSpeed = 3.5f;
    public float turnSpeed = 3.5F;
    public string character = "蓋倫";
    public bool isDead = false;
    public bool gameOver = true;

    public byte lv = 16;
    public nint coin = 9999;
    public long items = 3000;
}
