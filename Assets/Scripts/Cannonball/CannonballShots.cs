using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CannonballShots : MonoBehaviour
{
    [SerializeField] private BallBase cannonballPrefab;
    [SerializeField] private GameObject cannon;
    private List<BallBase> ballsPool = new List<BallBase>();


    public void Shoot()
    {
        int force = Random.Range(1200, 2000);
        BallBase currentBall = GetLooseBall();
        
        if (currentBall == null)
        {
            currentBall = CreateNewObject();
        }
        currentBall.gameObject.SetActive(true);        
        currentBall.RigitbodyBall.AddForce(currentBall.transform.forward * force, ForceMode.Force);
    }

    private void TransformPosition( BallBase go, GameObject cannonPosition)
    {
        go.transform.position = cannonPosition.transform.position;
        go.transform.rotation = cannonPosition.transform.rotation;
        go.transform.Translate(0, 0.75f, 1f);
        go.RigitbodyBall.velocity = Vector3.zero;
    }
    
    private BallBase CreateNewObject()
    {
        var go = Instantiate(cannonballPrefab);
        TransformPosition(go, cannon);        
        ballsPool.Add(go);
        
        return go;
    }

    private BallBase GetLooseBall()
    {
        foreach(var item in ballsPool) 
        {
            if (item.isActiveAndEnabled != true)
            {
                TransformPosition(item, cannon);                
                return item;
            }
            
        }
        return null;
    }
}    

