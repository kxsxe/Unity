using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test15 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int hp = 180;
        if (hp <= 50)
        {
            Debug.Log("������");
        }
        else if (hp >= 200)
        {
            Debug.Log("���ݣ�");
        }
        else
        {
            Debug.Log("��");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
