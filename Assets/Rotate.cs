using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotSpeed = 10f; // 도는 속도, public 으로 선언해서 에디터에서도 보인다.
    private float Speed; // 할당을 위한 변수 

    // Start is called before the first frame update
    void Start()
    {
        // Start 함수는 쓰지 않습니다.
    }

    // Update is called once per frame
    void Update() // Update = 매 프레임마다 실행 될 함수
    {
        if(Input.GetMouseButtonDown(0)) // GetMouseButtonDown = 마우스 클릭 이벤트,  ( 0 ) = 마우스 왼쪽 버튼 
        {   
            Speed = rotSpeed; // public으로 선언된 rotSpeed(10f) 를 private 로 선언된 Speed(0f) 에 할당해준다.
        }
        transform.Rotate(0,0,Speed); // 실질적으로 오브젝트를 돌게하는 코드. 
                                     // Rotate에는 인자값으로 (x, y, z) 가 들어가야 하는데, 
                                     //x, y축으로는 회전시키지 않고, z 축으로만 Speed 에 할당되어있는 속도로 회전한다.

        Speed *= 0.96f; // 도는 속도 줄이기용. 매 프레임마다 속도에 0.96을 곱한다.
        
    }
}
