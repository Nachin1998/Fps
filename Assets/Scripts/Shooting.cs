using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject weaponBarrel;
    public GameObject raycastEmitter;

    private Camera cam;
    public float maxTimeBetweenShots;
    private float timeBetweenShots;
    void Start()
    {
        cam = Camera.main;
    }
    
    void Update()
    {   
        Vector3 mousePos = Input.mousePosition;
        Ray ray = cam.ScreenPointToRay(mousePos);

        if (Input.GetMouseButton(0))
        {
            timeBetweenShots += Time.deltaTime;
            if (timeBetweenShots > maxTimeBetweenShots)
            {
                Debug.DrawRay(ray.origin, ray.direction * 50, Color.yellow);
                
            }
            if(timeBetweenShots > maxTimeBetweenShots * 1.5f)
            {
                timeBetweenShots = 0;
            }
        }
    }
}
