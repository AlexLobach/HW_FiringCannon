using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    [SerializeField] private ReducerAxis reducerAxis;
    [SerializeField] private CannonballShots cannonballShots;

    public void Update() 
    {
        reducerAxis.Rotate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime*20);

        if (Input.GetKeyDown(KeyCode.V))
        {
            cannonballShots.Shoot();
        }
    }
}
