using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
    public ParticleSystem particleUI;
    public void OnClick()
    {
        particleUI.Play();
    }
}
