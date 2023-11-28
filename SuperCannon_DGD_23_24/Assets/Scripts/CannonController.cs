using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    Quaternion clampRotationLow, clampRotationHigh;
    [SerializeField] GameObject bullet1prefab;
    [SerializeField] GameObject bullet2prefab;
    [SerializeField] float bulletFiringPeriod;

    Coroutine myFiringCoroutine1, myFiringCoroutine2;

    CannonFiring _firingInstance;
    // Start is called before the first frame update
    void Start()
    {
      _firingInstance =GetComponentInChildren<CannonFiring>();

      clampRotationLow = Quaternion.Euler(0f, 0f, -70f);
      clampRotationHigh = Quaternion.Euler(0f, 0f, +70f);
    }

    // Update is called once per frame
    void Update()
    {
        PointAtMouse();

        if (Input.GetMouseButtonDown(0)) 
        {
            //_firingInstance.FireCannon(bullet1prefab);
            if (myFiringCoroutine1 == null) myFiringCoroutine1 = StartCoroutine(FireContinuously(bullet1prefab));
        }
        if (Input.GetMouseButtonUp(0))
        {
            //_firingInstance.FireCannon(bullet1prefab);
            StopCoroutine(myFiringCoroutine1);
            myFiringCoroutine1 = null;
        }

        if (Input.GetMouseButtonDown(1))
        {
            //_firingInstance.FireCannon(bullet2prefab);  //to comment out when implemented coroutine 
            if (myFiringCoroutine2 == null) myFiringCoroutine2 = StartCoroutine(FireContinuously(bullet2prefab));
        }
        if (Input.GetMouseButtonUp(1))
        {
            //_firingInstance.FireCannon(bullet1prefab);
            StopCoroutine(myFiringCoroutine2);
            myFiringCoroutine2 = null;
        }

    }

    IEnumerator FireContinuously(GameObject mybulletPrefab)
    {
        while (true)
        {
            _firingInstance.FireCannon(mybulletPrefab);
            yield return new WaitForSeconds(bulletFiringPeriod);
        }

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
