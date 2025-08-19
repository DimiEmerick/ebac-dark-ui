using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Typper : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public float timeBetweenLetters = .1f;
    public string phrase;

    [NaughtyAttributes.Button]
    public void StartType()
    {
        StartCoroutine(Type(phrase));
    }

    IEnumerator Type(string s)
    {
        textMesh.text = "";
        foreach(char l in s.ToCharArray())
        {
            textMesh.text += l;
            yield return new WaitForSeconds(timeBetweenLetters);
        }
    }

    private void Awake()
    {
        textMesh.text = "";
    }
}
