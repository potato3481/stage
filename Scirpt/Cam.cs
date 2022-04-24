using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // 현재각도
    Vector3 angle;
    // 마우스감도
    public float sensitivity = 90;

    void Start()
    {

        Debug.Log("test" + Mathf.Deg2Rad * 180);
        // 시작할때 현재 카메라의 각도를 적용한다.
        //angle.y = -Camera.main.transform.eulerAngles.x;
        //angle.x = Camera.main.transform.eulerAngles.y;
        //angle.z = Camera.main.transform.eulerAngles.z;



        angle.x = transform.eulerAngles.x * Mathf.Deg2Rad;
        angle.y = transform.eulerAngles.y * Mathf.Deg2Rad;
        angle.z = transform.eulerAngles.z * Mathf.Deg2Rad;
    }

    void Update()
    {
        // 마우스 입력에 따라 카메라를 회전 시키고 싶다.
        // 1. 사용자의 마우스 입력을 얻어와야 한다.
        // 마우스의 좌우 입력을 받는다.


        //angle.x = transform.eulerAngles.x * Mathf.Deg2Rad;
        //angle.y = transform.eulerAngles.y * Mathf.Deg2Rad;
        //angle.z = transform.eulerAngles.z * Mathf.Deg2Rad;



        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");


        Debug.Log("x" + x);
        // Debug.Log("y"+y);
        // 2. 방향이 필요하다.
        // 이동 공식에 대입하여 각 속성별로 회전 값을 누적 시킨다.
        //angle.x += x * sensitivity * Time.deltaTime;
        //angle.y += y * sensitivity * Time.deltaTime;

        angle.x += x * sensitivity * Mathf.Deg2Rad;
        angle.y += y * sensitivity * Mathf.Deg2Rad;
        Debug.Log(angle);
        angle.y = Mathf.Clamp(angle.y, -90, 90);
        angle.x = Mathf.Clamp(angle.x, -90, 90);
        // 3. 회전 시키고 싶다.
        // 카메라의 회전값에 새로 만들어진 회전 값을 할당한다.
        //  transform.eulerAngles = new Vector3(-angle.y, angle.x, transform.eulerAngles.z);
        transform.eulerAngles = new Vector3(-angle.y * Mathf.Rad2Deg, angle.x * Mathf.Rad2Deg, 0);
    }

}
