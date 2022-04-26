using UnityEngine;

namespace NKNK
{





    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;
        [SerializeField, Header("���a����W��")]
        private string namePlayer = "�M�h";

        private Transform traPlayer;

        private void Awake()
        {
      
            traPlayer = GameObject.Find(namePlayer).transform;


            /*float result = Mathf.Lerp(0, 10, 0.5f);
            float result7 = Mathf.Lerp(0, 10, 0.7f);
            prinf("0 �P 10 �� 0.5 ����:" + result);
            prinf("0 �P 10 �� 0.7 ����:" + result7);
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
