using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beinSkipped : MonoBehaviour
{
    public AudioSource beinSource;
    public AudioClip clip;
    public GameObject procedureWarning;
    public void beinIsSkipped()
    {
        beinSource.PlayOneShot(clip);
        procedureWarning.SetActive(true);

        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(4);
        procedureWarning.SetActive(false);
    }
}
