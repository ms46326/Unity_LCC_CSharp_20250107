using UnityEngine;
namespace KID
{
    /// <summary>
    /// 類別 Class ：用來定義一個物件以及所擁有的資料與功能(成員)
    /// </summary>
    public class class_8_1_Class : MonoBehaviour
    {
        private void Awake()
        {
            // 實例化 NPC 並儲存在 npcJack 變數內
            class_8_1_NPC npcJack = new class_8_1_NPC();
            class_8_1_NPC npcKID = new class_8_1_NPC("KID","你好啊~");

            npcJack.LogName();
            npcKID.LogName();
            npcJack.Talk();
            npcKID.Talk();

        }
        
    }
}

