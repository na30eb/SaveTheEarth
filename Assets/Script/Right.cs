using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDrag(){
        GameObject.Find(name: "Player").transform.position+=new Vector3(0.1f,0,0);

    }
}
