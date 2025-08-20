using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypperHelper : MonoBehaviour
{
    public Typper typper;

    public void OnClickStartType()
    {
        typper.StartType();
    }
}
