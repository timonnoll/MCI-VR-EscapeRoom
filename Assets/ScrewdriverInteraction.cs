using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.Events;


public class ScrewdriverInteraction : MonoBehaviour
{
    public GameObject box;

    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag=="BoxPlane"){
            box.SetActive(false);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
