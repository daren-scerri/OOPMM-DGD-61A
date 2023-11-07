using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    Quaternion clampRotationLow, clampRotationHigh;

    // Start is called before the first frame update
    void Start()
    {
      clampRotationLow = Quaternion.Euler(0f, 0f, -70f);
      clampRotationHigh = Quaternion.Euler(0f, 0f, +70f);
    }

    // Update is called once per frame
    void Update()
    {
        PointAtMouse();
    }

    void PointAtMouse()
    {
        
        Quaternion newrotation = Quaternion.LookRotation(this.transform.position - GameData.MousePos, Vector3.forward);
        newrotation.x = 0f;
        newrotation.y = 0f;
        newrotation.z = Mathf.Clamp(newrotation.z, clampRotationLow.z, clampRotationHigh.z);
        newrotation.w = Mathf.Clamp(newrotation.w, clampRotationLow.w, clampRotationHigh.w);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 3f);
    }


}
