using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public GameObject DropItem;
    public Sprite Full, Broken;
    public AudioClip Break;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Full;
    }

    public void HitBarrel()
    {
        if (DropItem != null)
            Instantiate(DropItem, transform.position, Quaternion.identity);

        GameManager.Instance.AudioSource.PlayOneShot(Break);
        spriteRenderer.sprite = Broken;

        GetComponent<CapsuleCollider2D>().enabled = false;  
        GetComponent<Barrel>().enabled = false;
    }
}
