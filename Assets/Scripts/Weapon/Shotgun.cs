using UnityEngine;

public class Shotgun : Weapon
{
    private int _numberOfPellets = 5;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _numberOfPellets; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        }
    }
}