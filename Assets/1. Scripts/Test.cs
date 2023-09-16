using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public string myName;
    public int hp;

    void Start()
    {
        Debug.Log(myName);
    }

    void Update()
    {
        Debug.Log(hp);
    }
}
