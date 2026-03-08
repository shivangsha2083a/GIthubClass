using UnityEngine;

public class Ex_01_Cube : MonoBehaviour, ICubeInterface
{
    public AudioSource Source;
    public AudioClip Clip;
    public float Volume;
    private MeshRenderer _meshRenderer;
    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        cubeInteraction();
    }

    public void cubeInteraction()
    {
        PlaySound();
        var randomScale = Random.Range(0.1f, 2.5f);
        gameObject.transform.localScale = new Vector3(randomScale,randomScale,randomScale);
        var randomColor = Random.ColorHSV();
        _meshRenderer.material.color = randomColor;
    }
    public void PlaySound()
    {
        var sourcePitch = UnityEngine.Random.Range(-1f, 1f);
        Source.pitch = sourcePitch;
        Source.volume = Volume;   
        Source.clip = Clip;
        Source.Play();
    }
}
