using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
   // GameObject thePlayer = GameObject.Find("Player");
   // PlayerController player  = thePlayer.GetComponent<PlayerController>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
        Destroy(other.gameObject);
       // PlayerController.score += 1;
    }
}
