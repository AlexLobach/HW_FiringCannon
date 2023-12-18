using UnityEngine;

public class Contact : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        Debug.Log("you hit the target");
        
    }
}