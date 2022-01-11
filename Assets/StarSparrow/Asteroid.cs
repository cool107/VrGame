using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    private GameObject ExpObj;
    
    //충돌 연산 및 물리 힘까지 적용하는 메서드 호출
    private void OnTriggerEnter(Collider other)
    {
        //파괴하는 메서드 호출
        //Destroy(this.gameObject);
        //트리거가 작동하는 순간(충돌하는 순간)폭발하는 이벤트(파티션에서 가져 온 것-'ExplotionMobile')가 작동하도록 하는 메서드(현재 작동하지 않게 꺼놨음)
        ExpObj.SetActive(true);
        //메쉬렌더러(물질) 특성을 false로 보이지 않게 꺼버리는 것
        //쉽게 설명하면 오브젝트는 그자리에 있지만 화면상 보이지 않게 처리하는 것
        //메모리 효율에 그렇게 좋지는 않음, 제거 하는게 좋음
        transform.GetComponent<MeshRenderer>().enabled = false;

        //함수(메서드)를 실행하는 명령어, 문자열 ""안의 함수를 콤마 ,뒤의 시간(초) 이후에 함수를 실행함, 자바 스레드같은 느낌적인 느낌으로 사용할 것
        Invoke("DestObj", 2);
    }

    public void DestObj() 
    {
        //객체를 삭제하는 메서드
        Destroy(this.gameObject);
    }
}
