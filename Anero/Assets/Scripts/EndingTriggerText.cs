using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingTriggerText : MonoBehaviour
{
    public GameObject Holder;
    public Image bg, avatar;
    public TypeWriterEffect typeWriterEffect;
    public string Text;
    private int nextScene;
    private void Start()
    {
        if (bg == null)
            bg = GameObject.FindGameObjectWithTag("BG").GetComponent<Image>();

        if (avatar == null)
            avatar = GameObject.FindGameObjectWithTag("Avatar").GetComponent<Image>();

        if (typeWriterEffect == null)
            typeWriterEffect = GameObject.FindGameObjectWithTag("Text").GetComponent<TypeWriterEffect>();

        StartCoroutine("Starting");
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    private IEnumerator Starting()
    {
        yield return new WaitForSeconds(2f);
        StartText(Text);
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(nextScene);
    }

    public void StartText(string text)
    {
        bg.enabled = true;
        avatar.enabled = true;
        typeWriterEffect.StartText(text);
        typeWriterEffect.GetComponent<TextMeshProUGUI>().enabled = true;
        Destroy(Holder, 3f);
        StartCoroutine("ChangeScene");
    }

    
}
