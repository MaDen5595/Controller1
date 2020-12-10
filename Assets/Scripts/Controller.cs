using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject Cube;
    public GameObject ExampleCube;
    public Transform SpawnPoint;
    public bool cub = true;
    public Material Matt;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void NotActiv()
    {
        Cube.SetActive(false);
    }
    void NotActiv2()
    {
        Cube.GetComponent<MeshRenderer>().enabled = false;
    }
    void Activ()
    {
        Cube.SetActive(true);
    }
    void Activ2()
    {
        Cube.GetComponent<MeshRenderer>().enabled = true;
        Cube.GetComponent<MeshRenderer>().material = Matt;
    }
    void Spawneeer()
    {
        Cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
    void Spawneeer2()
    {
        MeshRenderer meshRenderer = Cube.AddComponent<MeshRenderer>();
    }
    void Destroyer()
    {
        Destroy(Cube);
    }
    void Destroyer2()
    {
        Destroy(Cube.GetComponent<MeshRenderer>());
    }
    void kubik()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Spawneeer();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroyer();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            NotActiv();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Activ();
        }
    }
    void rendr()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Spawneeer2();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroyer2();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            NotActiv2();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Activ2();
        }
    }
    void chang()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (cub == true)
            {
                cub = false;
            }
            else
            {
                cub = true;
            }
        }
    }
  
    // Update is called once per frame
    void Update()
    {
        chang();
        if (cub)
        {
            kubik();
        }
        else
        {
            rendr();
        }

    }
}
