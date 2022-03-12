using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CollectCrystals : MonoBehaviour
{
    int denemeCount;
    public TextMeshPro counterCollect;
    public TextMeshPro totalCrystals;

    public GameObject go;

    private void Start()
    {
        denemeCount = 0;
        totalCrystals.text = go.transform.childCount.ToString();
        counterCollect.text = denemeCount.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {

        Destroy(gameObject);
        denemeCount++;
        counterCollect.text = denemeCount.ToString();
    }

}



