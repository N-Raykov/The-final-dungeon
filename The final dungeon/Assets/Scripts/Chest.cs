using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int coinAmount = 25;

    protected override void OnCollect()
    {
        if (collected == false)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.coins += coinAmount;
            GameManager.instance.ShowText("+" + coinAmount + " coins!", 25, Color.yellow, transform.position, Vector3.up * 50, 1.5f);
        }
    }
}
