using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class TriggerMorePunks : MonoBehaviour
{
    public List<GameObject> Punks;

    private void Start()
    {
        Punks.ForEach(p => p.SetActive(false));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Punks.ForEach(p => p.SetActive(true));
        }
    }
}
