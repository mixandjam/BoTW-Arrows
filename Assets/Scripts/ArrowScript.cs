using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArrowScript : MonoBehaviour
{

    public GameObject hitParticle;

    public ParticleSystem trailParticle;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(hitParticle, transform.position, Quaternion.identity);
        trailParticle.transform.parent = transform.parent;
        trailParticle.Stop();

        Camera.main.transform.DOComplete();
        Camera.main.transform.DOShakePosition(.4f, .5f, 20, 90, false, true);

        Destroy(gameObject);
    }
}
