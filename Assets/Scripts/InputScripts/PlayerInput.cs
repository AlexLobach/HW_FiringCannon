using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInput : MonoBehaviour
{
    [SerializeField] 
    private RotateBase rotateBase;

    public void Update() 
    {
        rotateBase.Rotate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Time.deltaTime*20);
    }
}
