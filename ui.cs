using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
     GameObject flag;
     GameObject car;
     GameObject UItext;
    GameObject over;



    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
       UItext = GameObject.Find("UItext");
        over = GameObject.Find("overtext");
    }

    // Update is called once per frame
    void Update()
    {
        double er = flag.transform.position.x -
            car.transform.position.x;
        UItext.GetComponent<Text>().text = "�Z���ؼ��٦� " + er.ToString("F2") + "m";
        
        if (Input.GetMouseButtonUp(0))
        {
           
            if (er > 0)
            {
                double eq = car.transform.position.x;
                double en = eq * 4;
                over.GetComponent<Text>().text = "����: " + en.ToString("F2") + "��";
            }
            else if (er < 0)
            {
                over.GetComponent<Text>().text = "����:0��";
            }

        }

    }
}
