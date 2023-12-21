using System.Threading.Tasks;
using UnityEngine;

public class Contact : MonoBehaviour
{
    // void OnCollisionEnter(Collision other) {
    //     Debug.Log("you hit the target");
        
    // }
    async void OnTriggerEnter(Collider other)
    {
        await Task.Delay(1000);

        gameObject.SetActive(false);
    }
}