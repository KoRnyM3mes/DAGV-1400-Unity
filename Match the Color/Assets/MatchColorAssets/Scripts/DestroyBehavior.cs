using System;
using System.Collections;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public float seconds = 1;
    public WaitForSeconds wfsobj;
    IEnumerator Start()
    {
        wfsobj = new WaitForSeconds(seconds);
        yield return wfsobj;
        Destroy(gameObject);
    }
}
