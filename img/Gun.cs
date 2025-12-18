using UnityEngine;
public sealed class Gun : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float gravityForce;

    [Header("Ammo")]
    [SerializeField] private int currentAmmo = 10;
    [SerializeField] private PlayerHUD hud;

    private void Start()
    {
        hud.UpdateAmmo(currentAmmo);
    }

    public void AddAmmo(int amount)
    {
        currentAmmo += amount;
        hud.UpdateAmmo(currentAmmo);
        hud.ShowAmmoAdded(amount);
    }

    public void Shoot(Vector3 forward)
    {
        if (currentAmmo <= 0)
            return;

        currentAmmo--;
        hud.UpdateAmmo(currentAmmo);

        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            Quaternion.LookRotation(forward - firePoint.position) * Quaternion.Euler(90, 0, 0)
        );

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = (forward - firePoint.position).normalized * bulletSpeed;
        rb.AddForce(Vector3.down * gravityForce, ForceMode.Acceleration);
    }
}
