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
        throw new System.NotImplementedException();
    }

    protected override IEnumerator Reloading()
    {
        throw new System.NotImplementedException();
    }
}
