using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // ���簢��
    Vector3 angle;
    // ���콺����
    public float sensitivity = 90;

    void Start()
    {

        Debug.Log("test" + Mathf.Deg2Rad * 180);
        // �����Ҷ� ���� ī�޶��� ������ �����Ѵ�.
        //angle.y = -Camera.main.transform.eulerAngles.x;
        //angle.x = Camera.main.transform.eulerAngles.y;
        //angle.z = Camera.main.transform.eulerAngles.z;



        angle.x = transform.eulerAngles.x * Mathf.Deg2Rad;
        angle.y = transform.eulerAngles.y * Mathf.Deg2Rad;
        angle.z = transform.eulerAngles.z * Mathf.Deg2Rad;
    }

    void Update()
    {
        // ���콺 �Է¿� ���� ī�޶� ȸ�� ��Ű�� �ʹ�.
        // 1. ������� ���콺 �Է��� ���;� �Ѵ�.
        // ���콺�� �¿� �Է��� �޴´�.


        //angle.x = transform.eulerAngles.x * Mathf.Deg2Rad;
        //angle.y = transform.eulerAngles.y * Mathf.Deg2Rad;
        //angle.z = transform.eulerAngles.z * Mathf.Deg2Rad;



        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");


        Debug.Log("x" + x);
        // Debug.Log("y"+y);
        // 2. ������ �ʿ��ϴ�.
        // �̵� ���Ŀ� �����Ͽ� �� �Ӽ����� ȸ�� ���� ���� ��Ų��.
        //angle.x += x * sensitivity * Time.deltaTime;
        //angle.y += y * sensitivity * Time.deltaTime;

        angle.x += x * sensitivity * Mathf.Deg2Rad;
        angle.y += y * sensitivity * Mathf.Deg2Rad;
        Debug.Log(angle);
        angle.y = Mathf.Clamp(angle.y, -90, 90);
        angle.x = Mathf.Clamp(angle.x, -90, 90);
        // 3. ȸ�� ��Ű�� �ʹ�.
        // ī�޶��� ȸ������ ���� ������� ȸ�� ���� �Ҵ��Ѵ�.
        //  transform.eulerAngles = new Vector3(-angle.y, angle.x, transform.eulerAngles.z);
        transform.eulerAngles = new Vector3(-angle.y * Mathf.Rad2Deg, angle.x * Mathf.Rad2Deg, 0);
    }

}
