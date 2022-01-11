using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //버튼 구현 함수는 start, update등을 사용하여 실시간으로 연동할 필요가 없음
    //그렇기 때문에 직접 함수 구현

    public void PlayGame()
    {
        //LoadScene()에 입력하는 값은 실제 유니티 에디터 창의 Scene이름과 동일해야함(대소문자 구분)
        //다른 scene을 불러오는 명령어(여기에서는 게임시작 씬을 불러옮)
        SceneManager.LoadScene("GameScene");
    }

    public void goToSelect() 
    {
        //기체를 선택하는 scene을 불러오는 명령어
        SceneManager.LoadScene("SelectScene");
    }
}
