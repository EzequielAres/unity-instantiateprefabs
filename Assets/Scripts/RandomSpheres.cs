using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpheres : MonoBehaviour
{
    public GameObject sphere;

    private GameObject newSphere;
    private Renderer sphereRenderer;
    float x;
    float y;
    float z;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            x = Random.Range(-11, 11);
            y = Random.Range(10, 25);
            z = Random.Range(-7, 7);
            pos = new Vector3(x, y, z);

            newSphere = Instantiate(sphere, pos, Quaternion.identity);
            sphereRenderer = newSphere.GetComponent<Renderer>();
            sphereRenderer.material.color = Random.ColorHSV();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
