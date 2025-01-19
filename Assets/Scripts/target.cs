using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public AudioSource dieSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        Die();
    }

    void Die()
    {
        audioManager.Instance.PlaySFX("TargetHit", dieSound);
        
        //Destroy(gameObject);
    }
}
