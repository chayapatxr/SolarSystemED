using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularPath : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;
    public float radius = 1f;
    public float angle = 0f;
    public float newAngle;

    private Vector3 planetScale;
    public Vector3 planetPosition;
    private bool isMove = true;

    private void Awake(){
        planetPosition.x = target.position.x + Mathf.Cos(angle) * radius;
        planetPosition.y = target.position.y;
        planetPosition.z = target.position.z + Mathf.Sin(angle) * radius;
        planetScale = this.transform.localScale;
    }

    private void Update(){
        if(isMove){
            MovePlanet();
        }else if(!isMove){
            SortPlanet();
        }
    }

    public void SolarSystemStatus(bool isMove){
        this.isMove = isMove;
    }

    private void MovePlanet(){
        float x = target.position.x + Mathf.Cos(angle) * radius;
        float y = target.position.y;
        float z = target.position.z + Mathf.Sin(angle) * radius;

        transform.position = new Vector3(x, y, z);
        angle += (speed*10) * Time.deltaTime;   
    }

    private void SortPlanet(){
        
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, planetPosition.x, .05f),
            Mathf.Lerp(transform.position.y, planetPosition.y, .05f),
            Mathf.Lerp(transform.position.z, planetPosition.z, .05f)
            );
        
    }
}
