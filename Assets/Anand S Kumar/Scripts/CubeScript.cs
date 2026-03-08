using System;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    public GameObject text,textOrigin;
    private int _textNumber =1;
    private TextMeshPro  _textMeshProUGUI;
    public AnimationCurve curve;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _textMeshProUGUI = text.GetComponent<TextMeshPro>();
        _textMeshProUGUI.text = "0";
    }

    public void OnMouseDown()
    {
        StartCoroutine(scaleAnimation(new Vector3(2.0f, 2.0f, 2.0f)));
        var randomColor = UnityEngine.Random.ColorHSV();
        _meshRenderer.material.color = randomColor;
        _textMeshProUGUI.text = _textNumber.ToString();
        _textNumber++;
        
        StartCoroutine(scaleAnimation(Vector3.zero));
        if (_textNumber == 10)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator scaleAnimation(Vector3 scale)
    {
        var f = 0f;
        while (f < 1)
        {
            f += Time.deltaTime;
            var c = curve.Evaluate(f);
            textOrigin.transform.localScale = Vector3.Lerp(textOrigin.transform.localScale, scale,c );
            yield return null;
        }
        yield return null;
    }

    
}
