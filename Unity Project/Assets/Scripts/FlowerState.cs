using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerState : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRenderer;
    public Sprite[] plantArray;
    public int currentPlant;

    public void ChangePlantStage()
    {

        spriteRenderer.sprite = plantArray[currentPlant];
        currentPlant++;

        if (currentPlant >= plantArray.Length)
        {
            currentPlant = 0;

        }
    }
}
