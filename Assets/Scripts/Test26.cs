using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test26 : MonoBehaviour
{
    void CallName(string name)
    {
        Debug.Log("Hello " + name);
    }

    // Start is called before the first frame update
    void Start()
    {
        CallName("Tom");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
