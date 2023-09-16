using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    void Start()
    {
        for (int i = 0; i < 99; i++)
        {
            Instantiate(prefab);
        }
    }
}
