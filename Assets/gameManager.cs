using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour
{

    public GameObject objSphere;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("mouse 0"))
        {
            GameObject.Instantiate(objSphere, new Vector3(264, 206, 112), Quaternion.identity);
        }
    }
}