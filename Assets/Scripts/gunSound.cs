using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunSound : MonoBehaviour
{
    public AudioSource bang;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            audioManager.Instance.PlaySFX("Gun", bang);
        }
    }
}
