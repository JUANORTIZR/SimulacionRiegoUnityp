using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class riegogirar : MonoBehaviour
{
    public float vel;
    void Update()
    {
        {
            transform.Rotate(new Vector3(0f,1*vel*Time.deltaTime,0f));
        }
    }

}
