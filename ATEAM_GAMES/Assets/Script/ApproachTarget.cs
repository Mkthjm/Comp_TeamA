using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApproachTarget : MonoBehaviour
{
    //ターゲットオブジェクトのTransformのトランスフォルムコンポーネントを格納する変数
    public Transform target;
    public float moveSpeed;//オブジェクトの移動速度を格納する変数
    //public float stopDistance; //オブジェクトに向かって移動を開始する距離を格納する変数
    //public float moveDistance;//オブジェクトがターゲットに向かって移動を開始する距離を格納する変数
    //旋回するターゲット
    [SerializeField]
    private Transform targetplayer;
    //現在の角度
    private float angle;
    //回転するスピード
    [SerializeField]
    private float rotateSpeed = 180.0f;
    //ターゲットからの距離
    [SerializeField]
    private Vector3 distanceFromTarget = new Vector3(0f, 1f, 2f);

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //ターゲットポジションを作成して、ターゲットオブジェクトの座標を
        Vector3 targetPos = target.position;
        targetPos.y = transform.position.y;
        transform.LookAt(targetPos);
        float distance = Vector3.Distance(transform.position, target.position);

        ////回転処理
        ////　ユニットの位置 = ターゲットの位置 ＋ ターゲットから見たユニットの角度 ×　ターゲットからの距離
        //transform.position = targetplayer.position + Quaternion.Euler(0f, -angle, 0f) * distanceFromTarget;
        ////　ユニット自身の角度 = ターゲットから見たユニットの方向の角度を計算しそれをユニットの角度に設定する
        //transform.rotation = Quaternion.LookRotation(transform.position - new Vector3(target.position.x, transform.position.y, target.position.z), Vector3.up);
        ////　ユニットの角度を変更
        //angle += rotateSpeed * Time.deltaTime;
        ////　角度を0～360度の間で繰り返す
        //angle = Mathf.Repeat(angle, 360f);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SuckArea")){
            transform.position = transform.position + transform.forward * moveSpeed * Time.deltaTime;
        }
        
    }
}
