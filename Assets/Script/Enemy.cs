using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabs2 ;
    public GameObject vessel2 ;
    public float randomYlocation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomYlocation= Random.Range(-10f,10.5f);
        vessel2=Instantiate(prefabs2,new Vector3(randomYlocation,5.80f,0),Quaternion.identity) as GameObject;
        transform.position+=new Vector3(0,0.2f,0);

    
    }
    void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag=="Bullet"){
            Destroy(gameObject);
             Destroy(col.gameObject);

        }
    }
}
