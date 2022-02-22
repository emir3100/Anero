using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TriggerText : MonoBehaviour
{
    public GameObject Player;
    public Image bg, avatar;
    public TypeWriterEffect typeWriterEffect;
    public string Text;
    public bool HideOnView;
    private bool currentView = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !currentView)
        {
            StartText(Text);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !currentView)
        {
            bg.enabled = true;  
            avatar.enabled = true;
            typeWriterEffect.GetComponent<TextMeshProUGUI>().enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        bg.enabled = false;
        avatar.enabled = false;
        typeWriterEffect.GetComponent<TextMeshProUGUI>().enabled = false;
        typeWriterEffect.audioSource.Stop();

        if (HideOnView)
            currentView = true;
    }

    private void Update()
    {
        if(typeWriterEffect.TextStarted == false && GameManager.Instance.GameStarted)
        {
            Player.GetComponent<CharacterController2D>().enabled = true;
            Player.GetComponent<PlayerCombat>().enabled = true;
        }
    }

    public void StartText(string text)
    {
        bg.enabled = true;
        avatar.enabled = true;
        typeWriterEffect.StartText(text);
        Player.GetComponent<PlayerMovement>().StopPlayer();
        Player.GetComponent<CharacterController2D>().enabled = false;
        Player.GetComponent<PlayerCombat>().enabled = false;
        typeWriterEffect.GetComponent<TextMeshProUGUI>().enabled = true;
    }
}
