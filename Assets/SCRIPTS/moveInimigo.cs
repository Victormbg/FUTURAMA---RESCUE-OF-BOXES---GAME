using UnityEngine;
using System.Collections;

public class moveInimigo : MonoBehaviour
{
    public float vel;

    void Update()
    {
        transform.Translate(-vel * Time.deltaTime, 0, 0);
    }
}

