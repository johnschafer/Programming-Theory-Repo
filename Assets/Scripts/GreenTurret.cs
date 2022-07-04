using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTurret : Turret
{
    [SerializeField] GameObject laser;

    // Start is called before the first frame update
    void Start()
    {
        ShootingTime = .5f;
        ReloadingTime = .5f;
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
