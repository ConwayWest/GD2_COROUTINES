using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMatChange : MonoBehaviour
{
    public Material[] matList;
    int matNum;
    Renderer sphereRend;
    // Start is called before the first frame update
    void Start()
    {
        sphereRend = GetComponent<Renderer>();
        matNum = matList.Length;
        StartCoroutine("slowUpdate");
    }

    IEnumerator slowUpdate()
    {
        while(true)
        {
            Debug.Log(matList.Length);
            sphereRend.sharedMaterial = matList[Random.Range(0, matNum)];
            yield return new WaitForSeconds(.5f);
        }
    }
}
