using System.Threading.Tasks;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public Rigidbody RigitbodyBall;    
   
    async void OnTriggerEnter(Collider other)
    {
        await Task.Delay(1500);
        gameObject.SetActive(false);
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<Target>(out var target))
        {
            target.GetDamage(Random.Range(7, 12));
            gameObject.SetActive(false);
            
        }
    }
}