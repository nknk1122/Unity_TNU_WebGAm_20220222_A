using UnityEngine;

namespace NKNK
{ 
public class WeaponSystem : MonoBehaviour
{
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataWeapon;




        private float timer;

        private  void OnDrawGizmos()
        {


            Gizmos.color = new Color(1, 0, 0, 0.5f);


           
            for (int i = 0; i < dataWeapon.v2SpawnPoint.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataWeapon.v2SpawnPoint[i], 0.1f);
            }
        }

        private void Update()
        {
            SpawnWeapon();
        }



        private void SpawnWeapon()
        {
            print("�g�L�ɶ�:" + timer);

            if(timer >= dataWeapon.interval)
            {
                Instantiate(dataWeapon.goWeapon);

                timer = 0;
            }

            else
            {

                timer += Time.deltaTime;
            }
        }
}
}
