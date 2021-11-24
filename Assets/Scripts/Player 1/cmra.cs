using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class cmra : MonoBehaviour
{
    GameObject Player;
    public List<Transform> targets;

    public Vector3 offset;
    public float smoothTime = .5f;

    public float minZoom = 40f;
    public float maxZoom = 10f;
    public float zoomLimiter = 50f;
    public float fieldOfView;

    private Vector3 velocity;
    private Camera cam;

    


    private void Start()
    {
        
        cam = GetComponent<Camera>();
        Player = GameObject.FindWithTag("Player");
    }

    public void Update()
    {
       
        
            foreach(Transform go in targets) {

                if (targets[1] != null && targets[0] == null)
                {
                    targets.Remove(targets[0]);
                }
                

                if (targets[1] == null && targets[0] != null)
                {
                    targets.Remove(targets[1]);
            }
            else
            {
                break;
            }

            }   


    }
    private void LateUpdate()
    {
        if (targets.Count == 0)
            return;
        Move();
        Zoom();

        
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / 50f);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
    }
    void Move() {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

    transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }

    float GetGreatestDistance()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
        return bounds.size.x;
    }
    
    Vector3 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;

    }





}
