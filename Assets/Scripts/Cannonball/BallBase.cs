using System.Threading.Tasks;
using UnityEngine;

public class BallBase : MonoBehaviour
{
    public Rigidbody RigitbodyBall;    
   
    async void OnTriggerEnter(Collider other)
    {
        await Task.Delay(2000);
        gameObject.SetActive(false);
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<Target>(out var target))
        {
            target.GetDamage(Random.Range(5, 10));
            gameObject.SetActive(false);
            
        }
    }
}