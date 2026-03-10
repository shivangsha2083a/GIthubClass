using UnityEngine;

public class BallShrink : MonoBehaviour
{
    public AudioSource sound;

    void OnMouseDown()
    {
        StartCoroutine(Shrink());
        sound.Play();
    }

    System.Collections.IEnumerator Shrink()
    {
        transform.localScale = new Vector3(0.5f,0.5f,0.5f);

        yield return new WaitForSeconds(0.5f);

        transform.localScale = new Vector3(1f,1f,1f);
    }
}