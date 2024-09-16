using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxManager;

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxManager, spawnPosition, Quaternion.identity);
    }
}
