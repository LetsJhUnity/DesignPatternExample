using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    //�浹 �� ����� �ҽ� ������Ʈ�� ������ �÷��̸� �����ϰ�
    //��ü�� �ı��մϴ�.
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("���� ���!");
        Destroy(gameObject);
    }
     
    //�� �ڵ尡 ����Ǹ� ���� ���� �߻��ұ��? 2
    //1. ����� �÷��� �� ����� ��� �� �ı��˴ϴ�.
    //2. ����� �÷��̰� ���� �ʰ� ����װ� ��µǰ� �ı��˴ϴ�.
    //3. ������Ʈ�� �ٷ� �ı��˴ϴ�.

}
