using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectShip : MonoBehaviour
{
    public void Sparrow1()
    {
        //시작 화면에서 비행선을 클릭하면 호출되는 함수 선언
        //get, set과 동일한 사용법 "ShipType"에 1을 저장
        PlayerPrefs.SetInt("ShipType", 1);
        SceneManager.LoadScene("GameScene");
    }

    public void Sparrow2()
    {
        //시작 화면에서 비행선을 클릭하면 호출되는 함수 선언
        //get, set과 동일한 사용법 "ShipType"에 2를 저장
        PlayerPrefs.SetInt("ShipType", 2);
        SceneManager.LoadScene("GameScene");
    }
}
