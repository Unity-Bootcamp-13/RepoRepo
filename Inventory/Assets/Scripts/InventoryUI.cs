using Gpm.Ui;
using UnityEngine;


// 1000개의 아이템 추가
public class InventoryUI : MonoBehaviour
{
    public InfiniteScroll scroll;
    public InfiniteScrollData[] datas;
    class MyData : InfiniteScrollData
    {
        public InfiniteScrollData Data;
        public MyData(InfiniteScrollData data)
        {
            Data = data;
        }
    }

    void InsertData()
    {
        for (int i = 0; i < 1000; i++)
        {
            MyData data = new MyData(datas[i]);
            scroll.InsertData(data);
        }
    }

    private void Start()
    {
        InsertData();
    }

}
