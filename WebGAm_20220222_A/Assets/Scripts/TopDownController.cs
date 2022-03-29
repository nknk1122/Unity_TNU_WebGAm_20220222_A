using UnityEngine;

namespace NKNK
{
    public class TopDownController : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn�����,�Ҧp���ʳt�� �ʵe�ѼƦW�٩Τ��󵥸��
        // ���y�k:�׹��� ������� ���W�� (���w �w�]��);
        // [] �ݩ� Attritube
        // SerializeField �ǦC����� - ���i���� (�X�{�b�ݩʭ��O Inspector)
        // Header ���D
        // Range �d��:  
        [SerializeField, Header("���ʳt��"), Range(0, 500)]
        private float speed = 1.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        private float h;
        private float v;
        #endregion

        #region �ƥ�:�{�����J�f(Unity)
        // ����ƥ�:����C�������@��,�B�z��l��
        private void Awake()
        {
            // GetComponent<�x��>() - ����������
            // ��� ���w ���o����<����W��>() - ���o���w����s������
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        // ��s�ƥ�:�� 60 FPS (Frame per second)
        private void Update()
        {
            GetInput();
            Move();
            Rotate();
        }
        #endregion

        #region ��k:���������欰,�Ҧp���ʥ\�� ��s�ʵe





        private void GetInput()
        {





            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            
        }





        private void Move()
        {


            rig.velocity = new Vector2(h, v) * speed;

            ani.SetBool(parameterRun, h != 0 || v != 0);
        }






        private void Rotate()
        {



            transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
        }
        #endregion
    }
}
