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
            //�̱��� Ŭ����.Instance.�޼ҵ���� ���� ��� ���
            int result = ADManager.Instance.getPoint();
            Debug.Log($"���� ����Ʈ : {result}");
        }
        
    }
}
