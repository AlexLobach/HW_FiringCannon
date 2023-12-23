using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 20; 
    public PlayerInput InputModule;
    public ReducerAxis RotationModule;
    public CannonballShots ShootModule;
    public UIHandler UIModule;
    public static GameHandler GameInstance;



    public void Awake()
    {
        GameInstance = this; 
    } 

    public void Update()
    {
        RotationModule.Rotate(InputModule.InputRotation * rotationSpeed);
        KeyBoardInput();          
    }

    private void KeyBoardInput()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            ShootModule.Shoot();
        }
    }
    
    public static void SetScoreUI(int score)
    {
        //UIModule.SetScore($"score: {score}");
    }

}
