using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class dynamicPOV : MonoBehaviour
{
    private CinemachineVirtualCamera virtualcam;
    public int maxPOV;
    public int minPOV;
    public float zoomValue;

    void Awake() 
    {
        virtualcam = GetComponent<CinemachineVirtualCamera>();
    }

    void Start()
    {
        virtualcam.m_Lens.FieldOfView = 40;
    }

    void Update()
    {
        virtualcam.m_Lens.FieldOfView = Map(transform.position.y, 0.14f, 5.12f, minPOV, maxPOV) + zoomValue;

        if (Input.GetMouseButtonDown(1))
        {
            zoomValue -= 10;
        }
        if(Input.GetMouseButtonUp(1))
        {
            zoomValue += 10;
        }
    }
    private static float Map (float value, float fromSource, float toSource, float fromTarget, float toTarget)
    {
        return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
    }
}
