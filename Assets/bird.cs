using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Bird : MonoBehaviour
{
    public static Bird instance;
    private Rigidbody2D rb;
    public bool isArmored = false;

    public int bonus = 0;
    public int Bonus
    {
        get { return bonus; }
        set { if (value < 0) return; bonus = value; }
    } 
    Vector3 startPos;
    private Vector3 force;
    [SerializeField] private Vector3 forceMultipliers;
    float cooldown;
    bool check;
    float yVelocityControl = -30f;
    Quaternion target;
    public Light2D sun;
    float targetIntensity;
    public GameObject armor;

    public bool IsDead = false;
    private void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        targetIntensity = 0.67f;
    }


    private void Update()
    {

        if (IsDead)
        {
            targetIntensity = Mathf.Lerp(targetIntensity, 0, Time.deltaTime + 0.03f);
            sun.intensity = targetIntensity;
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -70, -40));
        }
        else
        {

            yVelocityControl = -10f;
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, yVelocityControl, 25f));//20f

            //Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            //difference.Normalize();

            var rv = rb.velocity.normalized;
            float rotationZ = Mathf.Atan2(rv.y, rv.x) * Mathf.Rad2Deg;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            if (rb.velocity != Vector2.zero)
                target = Quaternion.Euler(0, 0, rotationZ - 90);
            if (target.z > -0.5 && target.z < 0.5)
            {
                rb.constraints = RigidbodyConstraints2D.None;

                //rb.centerOfMass = new Vector2(rb.centerOfMass.x, 10);

                transform.GetChild(0).rotation = Quaternion.Lerp(transform.GetChild(0).rotation, target, 4 * Time.deltaTime);
            }

            //transform.GetChild(0).rotation = Quaternion.Lerp(transform.GetChild(0).rotation, target, 10 * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z);
            //Debug.Log(rb.centerOfMass);

            //if (rb.position.x < -3) { 

            //target = Quaternion.Euler(rb.transform.rotation.x, rb.transform.rotation.y, -35);
            // rb.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 3f);
            // }
            // else if(rb.position.x > 3)
            // {
            //   Quaternion target = Quaternion.Euler(rb.transform.rotation.x, rb.transform.rotation.y, 35);
            //    rb.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 3f);

            // }

            if (Input.GetMouseButtonDown(0))
            {
                startPos = Input.mousePosition;

            }
            if (Input.GetMouseButton(0) && !check)
            {
                Time.timeScale = 0.4f;
                cooldown = 0.6f;
                force = (Input.mousePosition - startPos);
                Debug.Log(force);

                /*
                if ((Force.x) > 350)
                {
                    Force.x = 350;
                }
                else if (Force.x < -350)
                {
                    Force.x = -350;
                }
                if (Force.y > 800)
                {
                    Force.y = 800;
                }
                else if (Force.y < -800)
                {
                    Force.y = -800;
                }
                */

            }
            if (Input.GetMouseButtonUp(0) && cooldown == 0.6f)
            {
                // y_veloc_control = -1f;
                Time.timeScale = 1f;
                force = force.normalized;
                //Debug.Log(force);
                var appliedForce = new Vector3(force.x * forceMultipliers.x, force.y * forceMultipliers.y, force.z * forceMultipliers.z);
                if (rb.velocity.y < -20)
                {
                    rb.AddForce(appliedForce / 2, ForceMode2D.Impulse);
                }
                else
                {
                    rb.AddForce(appliedForce / 2);
                }

                check = true;



            }
            if (check)
            {
                cooldown = cooldown - Time.deltaTime;
                if (cooldown < 0)
                {
                    check = false;

                }
            }
        }


    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "bone")
        {
            bonus++;
            Debug.Log(bonus);
        }
        if (other.gameObject.CompareTag("Hit") || other.gameObject.CompareTag("laser"))
        {
            if(!isArmored)
            {
                IsDead = true;
                GameManager.Singleton.CallOnBirdDied();
                GameManager.Singleton.SetTimeScale(1f);
                return;
            }
            isArmored = false;
            bonus = 0;
            armor.SetActive(false);
        }
    }

    private void AddBonus(int amount)
    {
        bonus += amount;
        if (bonus >= 5)
        {
            isArmored = true;
            armor.SetActive(true);
        }
    }
}


