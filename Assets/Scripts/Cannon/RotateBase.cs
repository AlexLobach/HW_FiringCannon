using UnityEngine;

public class  RotateBase : RotateAxis
{

    [SerializeField] 
    private Transform axis;
    

    [SerializeField]
    private Vector2 current;

    void Awake()
    {
        ApplyRotation();
    }

    void ApplyRotation()
    {
       // axis.rotation = Quaternion.Euler(current.y, current.x, 0) ;
        axis.rotation = Quaternion.Euler(Mathf.Clamp(current.y , -15, 15), Mathf.Clamp(current.x, -15, 15), 0) ;    
    }   
            
    public override void Rotate(Vector2 vector)
    {
        current += vector;
        ApplyRotation();        
    }
    
}