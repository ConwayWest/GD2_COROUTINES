using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sphereSpawn : MonoBehaviour
{
    public GameObject myPrefab;
    public Text spawnText;
    int spawnCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawn");
    }

    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(myPrefab, new Vector3(Random.Range(-2.0f,2.0f), Random.Range(2.0f, 8.0f), Random.Range(-3.0f,3.0f)), Quaternion.identity);
            spawnCount += 1;
            spawnText.text = "Ball Count: " + spawnCount;
            yield return new WaitForSeconds(.05f);
        }
    }
}
