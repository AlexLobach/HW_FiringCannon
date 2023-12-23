using UnityEngine;

public class Target : MonoBehaviour
{
    private int currentHP = 100;


    public void GetDamage(int damage)
    {
        Debug.Log($"{damage} was taken");
        currentHP -= damage;

        if (currentHP <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}