using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{

    public Color color;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.color = Color.red;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("충돌 중입니다!");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.color = Color.white;
        
    }
}
