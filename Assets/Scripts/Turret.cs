using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Turret : MonoBehaviour
{
    private bool hasFired;

    private float shootingTime;
    private const float minShootingTime = 0.0f;
    private const float maxShootingTime = 5.0f;
    private float reloadingTime;
    private const float minReloadingTime = 0.0f;
    private const float maxReloadingTime = 5.0f;


    // Encapsulation
    protected float ShootingTime
    {
        get { return shootingTime; }
        set { shootingTime = Mathf.Clamp(value, minShootingTime, maxShootingTime); }
    }

    // Encapsulation
    protected float ReloadingTime
    {
        get { return reloadingTime; }
        set { reloadingTime = Mathf.Clamp(value, minReloadingTime, maxReloadingTime); }
    }

    // Polymorphism
    protected abstract IEnumerator Shooting();
    protected abstract IEnumerator Reloading();

    private void OnMouseDown()
    {
        if (hasFired)
        {
            return;
        }

        StartCoroutine(ShootingRoutine());

        IEnumerator ShootingRoutine()
        {
            hasFired = true;
            yield return Shooting();
            yield return Reloading();
            hasFired = false;
        }
    }
}
