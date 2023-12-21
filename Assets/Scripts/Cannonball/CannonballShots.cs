using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CannonballShots : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject cannonballPrefab;
    [SerializeField] private GameObject cannon;
    

       
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            float force = Random.Range(1200, 2000);
            GameObject cannonball = Instantiate(cannonballPrefab);
            cannonball.transform.position = cannon.transform.position;
            cannonball.transform.rotation = cannon.transform.rotation;
            cannonball.transform.Translate(0,0.75f,1f);
            cannonball.GetComponent<Rigidbody>().AddRelativeForce(cannonball.transform.forward * force, ForceMode.Force);
            //Destroy(cannonball, 5f);
        }
        
    }    
}
