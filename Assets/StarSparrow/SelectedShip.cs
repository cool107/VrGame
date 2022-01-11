using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedShip : MonoBehaviour
{
    public GameObject ship01;
    public GameObject ship02;

    // Start is called before the first frame update
    void Start()
    {
        //SelectShip에서 선택한 값 확인하여 각각의 선택된 값에 맞는 처리(비행선을 보여주는 작업)을 함
        if (PlayerPrefs.GetInt("ShipType") == 1)
        {
            ship01.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("ShipType") == 2)
        {
            ship02.SetActive(true);
        }
    }
}
