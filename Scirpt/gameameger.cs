using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameameger : MonoBehaviour
{
    public GameObject Cube;

    public GameObject grllery;
    public GameObject bullding;
    public GameObject ground;
    public GameObject monstrer;
    public GameObject img;
    public TextAsset text1;
    private int i;
    void img_create(int y) {
    GameObject g = Instantiate(img); 
        g.transform.position = new Vector3(5.1f, y, 20);
        g.transform.eulerAngles = new Vector3(0, 90, 0);
        GameObject u= Instantiate(img);
        u.transform.position = new Vector3(0, y, 25);
        u.transform.eulerAngles = new Vector3(0, 0, 0);
        GameObject z = Instantiate(img);
        z.transform.position = new Vector3(-5.1f, y,20);
        z.transform.eulerAngles = new Vector3(0, -90, 0);

    }

    void grllery_cteate(int y)
    {
        GameObject c = Instantiate(bullding);
        c.transform.position = new Vector3(37, 50, 87);
        GameObject d = Instantiate(ground);
        d.transform.position = new Vector3(0, y, 0);
        d.transform.position = new Vector3(0, y, 0);
         for (int i = 0;i < 10; i++)
        {
            GameObject a = Instantiate(grllery);
            a.transform.position = new Vector3( -11,65, i*20);
        }
         for (int  i = 0;i < 10; i++)
        {
            GameObject b = Instantiate(grllery);
            b.transform.position = new Vector3(-11, 63, i * 20);
            b.transform.eulerAngles = new Vector3(0, 180, 0);
        }
         for(int i = 0; i< 3; i++)
        {
            GameObject e = Instantiate(monstrer);
            e.transform.position = new Vector3(-8, 3,i *3);
            e.transform.eulerAngles = new Vector3(0, 90, 0);
        }
    }
    private void Start()
    {
        create();
        grllery_cteate(i);
        img_create(2);
        img_create(5);
    }
    public void create()
    {
        GameObject p = new GameObject("Parent");
        for (int i = 0; i < 30; i++) {
            if ((i + 1) % 10 == 0)
            {
                grllery_cteate(i * 2);
            }
            GameObject a  = Instantiate(Cube);
            a.transform.position = new Vector3(0,i*2,i*2);
            
            if (i == 29)
            {
                a.GetComponent<MeshRenderer>().material.color = new Color32(101, 59, 255,  0);
                a.transform.localScale = new Vector3(60, 2, 60);
                a.transform.position = new Vector3(0, (i * 2), (i * 3f));
                a.name = i.ToString();
            }
            else
            {
                a.transform.position = new Vector3(0, i * 2, i * 2);
            }
        }
    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //   Debug.Log(hit.collider.name);
    //    create();
    //}

}
