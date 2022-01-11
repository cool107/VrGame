using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    //Trigger 상태에서는 충돌이 되는것은 확인이 되지만, 물체는 뚫고 지나감, 유니티 에디터에서 Collider 부분 'IsTrigger' 체크박스 체크해 줘야함
    //충돌 연산은 가능 하지만 물리적인 힘이 작용하지 않는 상태
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TriggerExit");
    }


    //충돌 연산은 가능, 물리적인 힘(충돌 등)도 작용하는 상태
    //유니티 에디터에서 Collider(강체) 설정을 해야함
    ////물리적인 충돌이 시작될때 호출하는 메서드
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("CollisionEnter");
    //}

    ////충돌이 계속되고 있을때 호출되는 메서드
    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("CollisionStay");
    //}

    ////물리적인 충돌이 끝날때 호출되는 메서드
    //private void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("CollisionExit");
    //}

}
