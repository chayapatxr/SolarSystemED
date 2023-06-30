using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private Vector3 position;
    public Transform movePlanet;

    void Awake(){
        position = this.transform.position;
    }

    public void OnEnable(){
        transform.position = position;
        transform.rotation = movePlanet.rotation;
    }
}
