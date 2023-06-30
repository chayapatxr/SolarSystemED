using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject grabbable;
    public GameObject ungrabbable;
    public float waitingTime;

    public CircularPath[] _circularPaths;
    public bool status;

    // Start is called before the first frame update
    void Awake()
    {
        _circularPaths = FindObjectsOfType<CircularPath>();
    }

    void Start(){
        grabbable.SetActive(true);
        ungrabbable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            SwitchSystemStatusPoke();
        }
    }


    public void SwitchSystemStatusPoke(){
        status = !status;

        if(status){
            foreach(CircularPath circularPath in _circularPaths){
                circularPath.SolarSystemStatus(true);
                circularPath.angle = 0;
            }
            grabbable.SetActive(false);
            ungrabbable.SetActive(true);
        }else{
            foreach(CircularPath circularPath in _circularPaths){
                circularPath.SolarSystemStatus(false);
            }
            StartCoroutine(SwitchSystemStatus());
        }

    }

    IEnumerator SwitchSystemStatus(){
        yield return new WaitForSeconds(waitingTime);
        grabbable.SetActive(true);
        ungrabbable.SetActive(false);
    }
}
