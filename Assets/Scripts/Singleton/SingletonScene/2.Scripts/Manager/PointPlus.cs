using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPlus : MonoBehaviour
{
     // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //싱글톤 클래스.Instance.메소드명을 통해 기능 사용
            int result = ADManager.Instance.getPoint();
            Debug.Log($"현재 포인트 : {result}");
        }
        
    }
}
