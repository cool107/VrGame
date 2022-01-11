using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpcaeShipMovement : MonoBehaviour
{
    [SerializeField]
    public GameObject Head;
    [SerializeField]
    public GameObject Cam;
    [SerializeField]
    public GameObject SpaceShip;

    private float CurrRot;
    private float PrevRot;
    private float DeltRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Head 오브젝트가 이동을 하는데 캠 오브젝트가 바라보는 방향으로 이동을 하는 것(deltaTime의 속도만큼)
        //time.deltaTime 은 한 프레임당 걸리는 시간
        Head.transform.Translate(Cam.transform.forward * Time.deltaTime * 5f);
        Tilt();
    }

    void Tilt() 
    {
        //현재 로테이션값 구하기
        CurrRot = Cam.transform.eulerAngles.y;
        //현재 로테이션값과 이전 로테이션의 차이값 구하기
        DeltRot = CurrRot - PrevRot;
        //이전 회전값(로테이션)에 현재값 넣기
        PrevRot = CurrRot;

        //오른쪽으로 회전하고 있으면
        if (DeltRot > 0)
        {
            SpaceShip.transform.localRotation = Quaternion.Lerp(SpaceShip.transform.localRotation, Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, -45), Time.deltaTime);
        }
        //왼쪽으로 회전하고 있으면
        else if (DeltRot < 0)
        {
            SpaceShip.transform.localRotation = Quaternion.Lerp(SpaceShip.transform.localRotation, Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 45), Time.deltaTime);
        }
        //회전하고 있지 않으면
        else if (DeltRot == 0)
        {
            SpaceShip.transform.localRotation = Quaternion.Lerp(SpaceShip.transform.localRotation, Quaternion.Euler(SpaceShip.transform.localRotation.x, SpaceShip.transform.localRotation.y, 0), Time.deltaTime);
        }
    }
}
