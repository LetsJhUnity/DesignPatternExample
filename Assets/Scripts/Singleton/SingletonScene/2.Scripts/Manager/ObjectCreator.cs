using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject SpherePrefab;

    // Update is called once per frame
    void Update()
    {
        //���콺 ���� ��ư�� ������ ������ ��ǥ�� �������� ������ �����ϰڽ��ϴ�.
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 pos = new Vector3(0.0f, 3.91f, 0.0f);
            Instantiate(SpherePrefab, pos, Quaternion.identity);
        }
    }
}
