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
        GameObject bullet = Instantiate(grimoireProjectile);

       // Physics.IgnoreCollision(grimoireProjectile.GetComponent<Collider>(), projectileSpawn.parent.GetComponent<Collider>());

        grimoireProjectile.transform.position = projectileSpawn.position;

        Vector3 rotation = grimoireProjectile.transform.rotation.eulerAngles;

        grimoireProjectile.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        grimoireProjectile.transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);

        StartCoroutine(DestroyBulletAfterTime(grimoireProjectile, lifeTime));
    }

    private IEnumerator DestroyBulletAfterTime(GameObject grimoireProjectile, float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);
    }


}
