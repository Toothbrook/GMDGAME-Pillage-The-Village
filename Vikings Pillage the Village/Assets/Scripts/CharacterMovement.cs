using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CharacterMovement : MonoBehaviour
{

    [SerializeField]
    private Camera mcCamera;

    private Player_controls controls;
    private Animator animator;
    // Start is called before the first frame update
    public int speed;
    bool isOnGround = true;
    public Rigidbody PlayerBody;
    public int rotationSpeed;
    GameObject rotPoint;
    public float Health;
    HealthBarScript healthBarScript;
    [SerializeField]
    private GameObject Death;
    private ScoreScript scoreOnDeath;
    

    public bool inBoat;
    private void Awake()
    {
        controls = new Player_controls();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
    void Start()
    {
        rotPoint = GameObject.FindGameObjectWithTag("Player");
        PlayerBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        //cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        healthBarScript = GameObject.Find("PlayerHealthBar").GetComponent<HealthBarScript>();
        Health = healthBarScript.GetHealth();
        scoreOnDeath = GameObject.Find("Score").GetComponent<ScoreScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
        {
        isOnGround = true;
        //Debug.Log(collision.gameObject.tag);
        }


    

    private void FixedUpdate()
    {
        LookAround();
        movePlayer();
        Jump();
        Attack();
        Sprint();
        HpLeft();

    }
    private void Sprint()
    {
        float sprint = controls._3rdPersoncontroller.Sprint.ReadValue<float>();
        if (sprint != 0)
        {
            animator.SetFloat("Speed", 1);

        }
       
    }

    private void Attack()
    {
        //The fixedupdate updates so fast that by clicking one time the attack is changed twice from the update so the player attacks twice
        float attack = controls._3rdPersoncontroller.Attack.ReadValue<float>();
        
        if (attack != 0)
        {
            animator.SetTrigger("Attack");
        }
       // Debug.Log("attack: " + attack);
        
    }

    private void LookAround()
    {
        if (!inBoat)
        {
            var cameraSpeed = 30;
            float xAxis = controls._3rdPersoncontroller.LookAround.ReadValue<Vector2>().x * Time.deltaTime;
            float yAxis = controls._3rdPersoncontroller.LookAround.ReadValue<Vector2>().y * Time.deltaTime;
            rotPoint.transform.Rotate(Vector3.up, xAxis * cameraSpeed);
            //Debug.Log("Camera axis" + xAxis);

            float xRotationNow = mcCamera.transform.localEulerAngles.x;
            xRotationNow += yAxis * cameraSpeed;

            if (xRotationNow < 180)
            {
                xRotationNow = Mathf.Min(xRotationNow, 60);
            }
            else if (xRotationNow > 180)
            {
                xRotationNow = Mathf.Max(xRotationNow, 300);
            }
        }


        //Vector2 rotation = controls._3rdPersoncontroller.LookAround.ReadValue<Vector2>();
        //rotPoint.transform.Rotate(0, 10 * rotation.x * Time.deltaTime, 0, Space.Self);
        //Debug.Log("look: vector" + rotation);
    }

    private void Jump()
    {
        if (!inBoat)
        {
            float jumpHeight = controls._3rdPersoncontroller.Jump.ReadValue<float>();
            if (jumpHeight != 0 && isOnGround)
            {

                animator.SetTrigger("Jump");
                Vector3 MoveVector = transform.TransformDirection(new Vector3(0, jumpHeight)) * speed * 5;
                PlayerBody.velocity = new Vector3(PlayerBody.velocity.x, MoveVector.y, PlayerBody.velocity.z);
                isOnGround = false;
                Debug.Log("Jump vector: " + MoveVector);
            }
            //Debug.Log("Jump: " + jumpHeight);
        }
    }

    void movePlayer()
    {
        Vector3 MoveVector = new Vector3(0,0,0);
        if (!inBoat)
        {

            Vector3 v = controls._3rdPersoncontroller.Move.ReadValue<Vector2>();

            //Vector3 MoveVector = rotPoint.transform.rotation * Vector3.forward;
            //MoveVector = MoveVector.normalized + v * speed;
            MoveVector = transform.TransformDirection(v) * speed;

            var move = new Vector3(MoveVector.x, 0, MoveVector.y);

            if (animator.GetFloat("Speed") == 1)
        {
            move *= 1.5f;
        }

        PlayerBody.velocity = move;

            
            move = rotPoint.transform.rotation * move;

            PlayerBody.velocity = move;

        }

            if (MoveVector.y <= 2 && MoveVector.y >= -2 && MoveVector.x <= 2 && MoveVector.x >= -2)
            {
                animator.SetFloat("Speed", 0);
            }
            //Skal have lavet hvor det er en animation der går bagud når det er minus i stedet for samme animation i begge scenarier
            else if (MoveVector.y > 2 || MoveVector.y < -2)
            {
                animator.SetFloat("Speed", 0.5f);
            }
            else if (MoveVector.x > 2)
            {
                animator.SetFloat("Speed", 1.5f);
            }
            else if (MoveVector.x < -2)
            {
                animator.SetFloat("Speed", 2);
            }


            //Debug.Log("Movement vector: " + MoveVector.x);
        
    }


    public void HpLeft()
    {
        Health = healthBarScript.GetHealth();
        if (Health <= 0)
        {
            animator.SetBool("Dead", true);
            Death.SetActive(true);
            scoreOnDeath.addScoreOnDeath();
          
        }
        
        
    }

}
