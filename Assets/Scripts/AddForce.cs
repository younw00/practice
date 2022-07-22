using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public Vector3 ForceVector = Vector3.zero;
    public bool StartAddForce = false; //�� ������ true�� ���� ���� ���Ѵ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartAddForce == true)
        {
            StartAddForce = false;
            GetComponent<Rigidbody>().AddForce(ForceVector); //ForceVector�� ����ŭ ���� �ְ� �ȴ� ex) (1, 0, 0) �̸� X�� �������� 1�� ���� �شٰ� ����
        }
    }
}
