using UnityEngine;
using DG.Tweening;

public class Target : MonoBehaviour
{
    private int currentHP = 100;
    public int Bounty = 10;


    public void GetDamage(int damage)
    {
        transform.DOScale(2.5f, 0.3f).SetLoops(2, LoopType.Yoyo);

        Debug.Log($"{damage} was taken");
        currentHP -= damage;

        if (currentHP <= 0)
        {
            DeatchTarget();
        }
    }

    private void  DeatchTarget() 
    {
        gameObject.SetActive(false);
    }
}