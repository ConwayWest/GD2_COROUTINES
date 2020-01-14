using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatChange : MonoBehaviour
{
    Dropdown mainDrop;
    public Material[] matList;
    public Renderer cubeRend;
    // Start is called before the first frame update
    void Start()
    {
        mainDrop = GetComponent<Dropdown>();
        cubeRend.enabled = true;
        StartCoroutine("MaterialUpdate");
    }

    IEnumerator MaterialUpdate()
    {
        for (; ;)
        {
            if (mainDrop.value == 0)
            {
                cubeRend.sharedMaterial = matList[0];
            }
            else if (mainDrop.value == 1)
            {
                cubeRend.sharedMaterial = matList[1];
            }
            else if (mainDrop.value == 2)
            {
                cubeRend.sharedMaterial = matList[2];
            }
            else if (mainDrop.value == 3)
            {
                cubeRend.sharedMaterial = matList[3];
            }
            yield return new WaitForSeconds(.5f);
        }
    }
}
