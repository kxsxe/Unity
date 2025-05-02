using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test27 : MonoBehaviour
{
    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    // Start is called before the first frame update
    void Start()
    {
        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
