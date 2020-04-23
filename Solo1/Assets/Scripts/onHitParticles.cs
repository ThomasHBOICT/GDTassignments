using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHitParticles : MonoBehaviour
{
    public Gradient particleColorGradient;
    private ParticleSystem ps;
     

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        var main = ps.main;
        main.startColor = particleColorGradient.Evaluate(Random.Range(0f, 1f));
        Destroy(gameObject, 1);
    }
}
