using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActionDelayed : MonoBehaviour
{
    private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_AudioSource.Play();
        Destroy(gameObject, m_AudioSource.clip.length);
        //�ı��� Ŭ���� ���̸�ŭ�� ������(��� �ð��� �߰�)
    }
    //�� �ڵ尡 ����Ǹ� ���� ���� �߻��ұ��?  1
    //1. ����� �÷��� �� ����� ��� �� �ı��˴ϴ�.
    //2. ����� �÷��̰� ���� �ʰ� ����װ� ��µǰ� �ı��˴ϴ�.

    //���尡 �ȳ��� �������� �ذ������, ���ڿ������� ������ ������.(���� ������ �ı��Ǵ� �κ�)
    //���� ���� ó���� �Ǹ� ���� ���մϴ�.


}

