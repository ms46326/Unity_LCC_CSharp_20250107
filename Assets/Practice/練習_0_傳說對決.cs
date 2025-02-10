using UnityEngine;
using UnityEngine.UI;

public class HeroCounter : MonoBehaviour
{
    // 英雄名稱列表和職業分組
    public string[] tankHeroes = { "阿塔", "維羅", "古木", "諾可西", "伯頓", "艾瑞", "贊尼爾", "克萊斯", "渥馬爾", "塔拉", "薩尼", "牛魔王", "歐米茄", "美娜" };
    public string[] warriorHeroes = { "安格列", "筱清", "葉娜", "埃羅", "緋淚", "弗洛倫", "瑞克", "艾蜜莉", "洛克", "夜叉", "麥克思", "神力女超人", "龍馬", "艾翠絲", "阿杜恩", "凱格路士", "超人", "祖卡", "司科德", "莫托斯", "馬洛斯", "趙雲", "瑟斐斯", "呂布" };
    public string[] assassinHeroes = { "蘇離", "亞連", "潘因", "綺蘿", "銀晝", "奎倫", "莫拉", "蝙蝠俠", "愛里", "科里納卡", "納克羅斯", "孫悟空", "刀鋒寶貝" };
    public string[] mageHeroes = { "颯加", "狄拉克", "依夏", "達爾西", "瀾", "瑪迦", "閃電俠", "莉莉安", "圖倫", "伊耿士", "齊爾", "拉茲", "金納", "娜塔亞", "穆加爵", "克里希", "哥德爾", "卡莉" };
    public string[] marksmanHeroes = { "索文", "拉維爾", "蘭鐸", "亥牙", "卡芬妮", "蘇", "琳蒂", "小丑", "菲尼克", "凡恩", "堇", "勇" };

    // 記錄每個職業的計數
    private int[] tankCounts;
    private int[] warriorCounts;
    private int[] assassinCounts;
    private int[] mageCounts;
    private int[] marksmanCounts;

    void Start()
    {
        // 初始化計數器
        tankCounts = new int[tankHeroes.Length];
        warriorCounts = new int[warriorHeroes.Length];
        assassinCounts = new int[assassinHeroes.Length];
        mageCounts = new int[mageHeroes.Length];
        marksmanCounts = new int[marksmanHeroes.Length];

        // 創建 UI 按鈕並綁定事件
        CreateHeroButtons();
    }

    // 創建按鈕 UI，並顯示職業
    void CreateHeroButtons()
    {
        GameObject canvas = GameObject.Find("Canvas"); // 假設你的 Canvas 物件叫做 "Canvas"
        float yOffset = 0f;

        // 為每個職業創建一個區域，並生成對應的按鈕
        CreateButtonsForClass("坦克", tankHeroes, tankCounts, ref yOffset, canvas);
        CreateButtonsForClass("戰士", warriorHeroes, warriorCounts, ref yOffset, canvas);
        CreateButtonsForClass("刺客", assassinHeroes, assassinCounts, ref yOffset, canvas);
        CreateButtonsForClass("法師", mageHeroes, mageCounts, ref yOffset, canvas);
        CreateButtonsForClass("射手", marksmanHeroes, marksmanCounts, ref yOffset, canvas);
    }

    // 創建單個職業的按鈕
    void CreateButtonsForClass(string className, string[] heroes, int[] counts, ref float yOffset, GameObject canvas)
    {
        // 顯示職業名稱
        GameObject classText = new GameObject(className);
        Text classNameText = classText.AddComponent<Text>();
        classNameText.text = className;
        classNameText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        classNameText.fontSize = 30;
        classText.transform.SetParent(canvas.transform);
        classText.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -yOffset);
        yOffset -= 40;

        // 創建該職業的每個英雄按鈕
        for (int i = 0; i < heroes.Length; i++)
        {
            GameObject button = new GameObject(heroes[i]);
            button.AddComponent<Button>();
            button.transform.SetParent(canvas.transform);

            // 設定按鈕文本
            Text buttonText = button.AddComponent<Text>();
            buttonText.text = heroes[i];
            buttonText.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
            buttonText.fontSize = 20;

            // 設置按鈕的點擊事件
            Button btn = button.GetComponent<Button>();
            int index = i;  // 使用局部變量來保證正確的索引
            btn.onClick.AddListener(() => OnHeroButtonClick(className, index));

            // 設定按鈕位置
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -yOffset);
            yOffset -= 30; // 每個按鈕之間的間距
        }
    }

    // 點擊英雄按鈕時觸發
    void OnHeroButtonClick(string className, int index)
    {
        int count = 0;

        // 根據職業更新相應的計數
        switch (className)
        {
            case "坦克":
                tankCounts[index]++;
                count = tankCounts[index];
                break;
            case "戰士":
                warriorCounts[index]++;
                count = warriorCounts[index];
                break;
            case "刺客":
                assassinCounts[index]++;
                count = assassinCounts[index];
                break;
            case "法師":
                mageCounts[index]++;
                count = mageCounts[index];
                break;
            case "射手":
                marksmanCounts[index]++;
                count = marksmanCounts[index];
                break;
        }

        // 顯示當前英雄的計數
        Debug.Log(className + " - " + index + " 的計數是：" + count);
    }
}
