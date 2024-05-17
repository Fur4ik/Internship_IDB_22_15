using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class table : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject Table;
    public GameObject Table1;
    public GameObject Table2;

    public Material[] materials;
    private int k=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void on()
    {
        Debug.Log("gjgjgj");
        if (k == 0)
        {
            Debug.Log("1");
            Table.GetComponent<MeshRenderer>().materials = Table1.GetComponent<MeshRenderer>().materials;
            k++; 
        }
        else
        {
            Debug.Log("2");
            Table.GetComponent<MeshRenderer>().materials= Table2.GetComponent<MeshRenderer>().materials;
            k--;
        }
        if (Table.GetComponent<MeshRenderer>().material == materials[0])
        {
            Debug.Log("1");
            Table.GetComponent<MeshRenderer>().material = materials[1];
        }
        else
        {
            if (Table.GetComponent<MeshRenderer>().material.mainTexture == materials[1])
            {
                Debug.Log("2");
                Table.GetComponent<MeshRenderer>().material = materials[0];
            }
        }

    }


}
