using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public Image DiscordTicketC;
    public Image OGTicketC;
    public Image WLTicketC;
    public int TicketsCollected = 0;

    private static Inventory instance;
    public static Inventory Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType<Inventory>();
            return instance;
        }
    }
    private void Start()
    {
        DiscordTicketC.enabled = false;
        OGTicketC.enabled = false;
        WLTicketC.enabled = false;
    }
    public void AddTicket(MyTicket myTicket)
    {
        switch (myTicket)
        {
            case MyTicket.Discord:
                DiscordTicketC.enabled = true;
                TicketsCollected += 1;
                break;
            case MyTicket.OG:
                OGTicketC.enabled = true;
                TicketsCollected += 1;
                break;
            case MyTicket.WL:
                WLTicketC.enabled = true;
                TicketsCollected += 1;
                break;
            default:
                break;
        }
    }
}
public enum MyTicket
{
    Discord,
    OG,
    WL
};