using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject prefabs ;
    public GameObject vessel ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDrag()
    {
        vessel=Instantiate(prefabs,new Vector3(
            GameObject.Find("Player").transform.position.x,
            GameObject.Find("Player").transform.position.y,
            0
            ),Quaternion.identity) as GameObject;
    }
}
