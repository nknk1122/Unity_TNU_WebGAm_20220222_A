using UnityEngine;

namespace NKNK
{





    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("玩家物件名稱")]
        private string namePlayer = "騎士";

        private Transform traPlayer;

        private void Awake()
        {
      
            traPlayer = GameObject.Find(namePlayer).transform;


            /*float result = Mathf.Lerp(0, 10, 0.5f);
            float result7 = Mathf.Lerp(0, 10, 0.7f);
            prinf("0 與 10 的 0.5 插值:" + result);
            prinf("0 與 10 的 0.7 插值:" + result7);
            */

        }

        private void Update()
        {
            MoveToPlayer();
        }




        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTimo);



            float y = transform.position.x > traPlayer.position.x ? 180 : 0;
            transform.eulerAngles = new Vector3(0, y, 0);
        }
    }
}
