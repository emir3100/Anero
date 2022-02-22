using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticket : MonoBehaviour
{
    public MyTicket TicketType;
    public AudioClip CollectedClip;
    public GameObject DropItem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.Instance.AudioSource.PlayOneShot(CollectedClip);
            Inventory.Instance.AddTicket(TicketType);
            if(DropItem != null)
                Instantiate(DropItem, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
