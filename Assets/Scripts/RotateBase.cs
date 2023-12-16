using UnityEngine;

public class  RotateBase : RotateAxis
{

    [SerializeField] 
    private Transform axis;
    

    [SerializeField]
    private Vector2 current;

    void void Awake()
    {
        ApplyRotation();
    }

    void ApplyRotation()
    {
        axis.rotation = Quaternion.Euler(current.x, current.y, 0);    
    }   
            
    public override void Rotate(Vector2 vector)
    {
        current += vector;
        ApplyRotation();        
    }
    
}