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
    //整數：儲存沒有小數點
    //浮點數：
    //字串：
    //布林值：
    public int count = 7;
    public float moveSpeed = 3.5f;
    public float turnSpeed = 3.5F;
    public string character = "蓋倫";
    public bool isDead = false;
    public bool gameOver = true;

    //整數資料類型
    public byte lv = 16;            //byte 型別，範圍 0 ~ 255，大小 8 byte
    public uint coin = 9999;        //uint 型別，範圍 0 ~ 255，大小 32 byte
    public long items = 3000;       //long 型別，範圍 0 ~ 255，大小 64 byte

    //字串與字元
    public string playname = "Aes"; //字串：儲存多個字元，使用雙引號
    public char sex = 'M';          //字元：儲存一個字元，使用單引號

    //溢位
    //public sbyte number = 128;    //溢位導致錯誤，會出現紅色蚯蚓
}
