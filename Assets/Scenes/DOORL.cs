using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOORL : MonoBehaviour
{
    // Start is called before the first frame update
    public float xmin, xmax, y, z;
    void Start()
    {
        xmin = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
        xmax = xmin + 0.8f;
       

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z != z)
        {
            this.transform.position= new Vector3(this.transform.position.x, y, z);
        }
        if (this.transform.position.y != y)
        {
            this.transform.position = new Vector3(this.transform.position.x,y, z);
        }
        if (this.transform.position.x < xmin)
        {
            this.transform.position = new Vector3(xmin, y, z);
        }
        if (this.transform.position.x > xmax)
        {
            this.transform.position = new Vector3(xmax, y, z);
        }
    }
}
