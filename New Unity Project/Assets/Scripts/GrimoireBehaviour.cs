using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimoireBehaviour : MonoBehaviour
{

    public GameObject grimoireProjectile;

    public Transform projectileSpawn;

    public float projectileSpeed = 30;

    public float lifeTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fire();
        }
    }


   

    private void fire()
    {

        GameObject projectile;

        projectile = Instantiate(grimoireProjectile, transform.position, projectileSpawn.transform.rotation);

        //projectile.transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);

        Rigidbody rb = projectile.GetComponent<Rigidbody>();

        rb.AddRelativeForce(Vector3.forward * projectileSpeed);

        StartCoroutine(DestroyBulletAfterTime(projectile, lifeTime));

      
    }

    private IEnumerator DestroyBulletAfterTime(GameObject grimoireProjectile, float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
        DestroyImmediate(grimoireProjectile, true);
    }


}
