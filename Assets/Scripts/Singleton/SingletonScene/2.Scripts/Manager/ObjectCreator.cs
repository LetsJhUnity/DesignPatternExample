using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject SpherePrefab;

    // Update is called once per frame
    void Update()
    {
        //마우스 왼쪽 버튼을 누르면 정해진 좌표에 프리팹을 생성을 진행하겠습니다.
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 pos = new Vector3(0.0f, 3.91f, 0.0f);
            Instantiate(SpherePrefab, pos, Quaternion.identity);
        }
    }
}
