using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_statements : MonoBehaviour
{
    public int age;
    // Start is called before the first frame update
    void Start()
    {
        if (age > 18)
        {
            Debug.Log("you can vote");
        }
        else
        {
            Debug.Log("you cannot vote");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
