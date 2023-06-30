using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class GrabPlanet : MonoBehaviour
{
    public GameObject[] planets;

    public void DisplayPlanet(GameObject planet){
        if(planet == null) return;

        foreach(GameObject pnt in planets){
            if(planet.name == pnt.name){
                pnt.SetActive(true);
            }else{
                pnt.SetActive(false);
            }
        }
    }
}
