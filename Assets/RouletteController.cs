using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotspeed = 0;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotspeed = 5.0f;
        }
        if (Input.GetMouseButtonDown(1))
        {
            while (this.rotspeed >= 1)
            {
                this.rotspeed = this.rotspeed * 0.0009f;
            }
        }
        transform.Rotate(0, 0, this.rotspeed);
    }
}
