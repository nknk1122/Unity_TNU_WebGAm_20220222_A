using UnityEngine;

namespace NKNK
{
    public class TopDownController : MonoBehaviour
    {
        #region 資料:保存系統需要的資料,例如移動速度 動畫參數名稱或元件等資料
        // 欄位語法:修飾詞 資料類型 欄位名稱 (指定 預設值);
        // [] 屬性 Attritube
        // SerializeField 序列化欄位 - 欄位可視化 (出現在屬性面板 Inspector)
        // Header 標題
        // Range 範圍:  
        [SerializeField, Header("移動速度"), Range(0, 500)]
        private float speed = 1.5f;
        private string parameterRun = "開關跑步";
        private string parameterDead = "開關死亡";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 事件:程式的入口(Unity)
        // 喚醒事件:撥放遊戲實執行一次,處理初始值
        private void Awake()
        {
            // GetComponent<泛型>() - 指任何類型
            // 欄位 指定 取得元件<元件名稱>() - 取得指定元件存放於欄位
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        #endregion

        #region 方法:較複雜的行為,例如移動功能 更新動畫
        #endregion
    }
}
