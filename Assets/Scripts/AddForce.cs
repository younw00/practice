using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public Vector3 ForceVector = Vector3.zero;
    public bool StartAddForce = false; //이 변수가 true일 때만 힘을 가한다
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
            GetComponent<Rigidbody>().AddForce(ForceVector); //ForceVector의 값만큼 힘을 주게 된다 ex) (1, 0, 0) 이면 X축 방향으로 1의 힘을 준다고 생각
        }
    }
}
