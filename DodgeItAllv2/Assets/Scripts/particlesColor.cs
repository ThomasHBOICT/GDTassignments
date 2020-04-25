using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlesColor : MonoBehaviour
{
    public Gradient gradient;

    private ParticleSystem ps;
    
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ParticleColor();
        Destroy(gameObject, 3f);
    }

    private void ParticleColor()
    {
        ParticleSystem.MainModule psMain = ps.main;
        psMain.startColor = gradient.Evaluate(Random.Range(0f, 1f));

    }
}
