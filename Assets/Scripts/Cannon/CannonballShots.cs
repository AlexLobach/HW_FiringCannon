using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CannonballShots : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cannonball_abs;
    [SerializeField]
    private GameObject cannon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            float force = Random.Range(1200, 2000);
            GameObject cannonball = Instantiate(cannonball_abs) as GameObject;
            cannonball.transform.position = cannon.transform.position;
            cannonball.transform.rotation = cannon.transform.rotation;
            cannonball.transform.Translate(0,0.75f,1f);
            cannonball.GetComponent<Rigidbody>().AddRelativeForce(cannonball.transform.forward * force, ForceMode.Force);

        }

    }
}
