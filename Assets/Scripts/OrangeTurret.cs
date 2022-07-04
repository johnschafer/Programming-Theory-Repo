using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeTurret : Turret
{
    [SerializeField] GameObject laser;

    // Start is called before the first frame update
    void Start()
    {
        ShootingTime = 1f;
        ReloadingTime = 3f;
    }

    protected override IEnumerator Shooting()
    {
        laser.SetActive(true);
        yield return new WaitForSeconds(ShootingTime);
        laser.SetActive(false);
    }

    protected override IEnumerator Reloading()
    {
        yield return new WaitForSeconds(ReloadingTime);
    }
}
