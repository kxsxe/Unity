using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test23 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] points = { 83, 99, 52, 93, 15 };

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] >= 90)
            {
                Debug.Log(points[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
