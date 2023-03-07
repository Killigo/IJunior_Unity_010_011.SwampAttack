using UnityEngine;

public class Shotgun : Weapon
{
    private int numberOfPellets = 5;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < numberOfPellets; i++)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        }
    }
}