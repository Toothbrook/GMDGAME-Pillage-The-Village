using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boat : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private Camera mcCamera;
    public GameObject enterText;
    private Player_controls controls;
    public bool isInVehicle;
    public bool inTransition;
    public Vector3 sittingPositionOffset;
    public Transform seat;
    GameObject rotPoint;
    public Transform exit;
    public Rigidbody ship;
    public int speed;
    public float enterAndExitSpeed;

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
    // Start is called before the first frame update
    void Start()
    {
       ship = GetComponent<Rigidbody>();
        rotPoint = GameObject.FindGameObjectWithTag("boat");
    }

    // Update is called once per frame
    void Update()
    {
        if (isInVehicle && inTransition)
        {
            ExitBoat();
        }
        else if (!isInVehicle && inTransition)
        {
            EnterBoat();
        }

        

        MoveBoat();
        LookAround();
        ifNearby();
    }

    void ifNearby()
    {
        if (Vector3.Distance(player.position, transform.position) < 10)
        {
            if (isInVehicle)
            {
                enterText.SetActive(false);
                Debug.Log("Deactivating");
            }
            else
            {
                enterText.SetActive(true);
                Debug.Log("activating");
            }

            if (controls.BoatController.EnterAndExit.ReadValue<float>() != 0)
            { 
                         inTransition = true;
            }
            
        }
        else
        {
            enterText.SetActive(false);
        }
        
        

        //Debug.Log("enter and exit:" + controls.BoatController.EnterAndExit.ReadValue<float>());
        Debug.Log("distance:" + Vector3.Distance(player.position, transform.position));
    }
        //Debug.Log(collision.gameObject.tag);


    private void EnterBoat()
    {
        // register in boat
        player.GetComponent<CharacterMovement>().inBoat = true;
        Debug.Log("enter boat");
        // Disable components
        player.GetComponent<MeshCollider>().enabled = false;
        player.GetComponent<Rigidbody>().useGravity = false;

        //Move to seat
        player.position = Vector3.Lerp(player.position, seat.position + sittingPositionOffset, enterAndExitSpeed);
        player.rotation = Quaternion.Slerp(player.rotation, seat.rotation, enterAndExitSpeed);

        // check if right position
        if (player.position == seat.position + sittingPositionOffset)
        {
            
            isInVehicle = true;
        }
        inTransition = false;
    }

    private void ExitBoat()
    {
        // move to exit
        player.position = Vector3.Lerp(player.position, exit.position, enterAndExitSpeed);
        Debug.Log("exit boat");
        // check if right position
        //if (player.position == exit.position)
        //{
            
            isInVehicle = false;
            //register leave boat
            player.GetComponent<CharacterMovement>().inBoat = false;
            // Enable compnents
            player.GetComponent<MeshCollider>().enabled = true;
            player.GetComponent<Rigidbody>().useGravity = true;
        //}
        inTransition = false;


    }

    private void MoveBoat()
    {
        Vector3 MoveVector = new Vector3(0, 0, 0);
        if (player.GetComponent<CharacterMovement>().inBoat)
        {

            Vector3 v = controls._3rdPersoncontroller.Move.ReadValue<Vector2>();

            //Vector3 MoveVector = rotPoint.transform.rotation * Vector3.forward;
            //MoveVector = MoveVector.normalized + v * speed;
            MoveVector = transform.TransformDirection(v) * speed;



            var move = new Vector3(MoveVector.y, 0, MoveVector.x*(-1));
            move = rotPoint.transform.rotation * move;

            ship.velocity = move;
            player.position = Vector3.Lerp(player.position, seat.position + sittingPositionOffset, speed);
            player.rotation = Quaternion.Slerp(player.rotation, seat.rotation, speed);

        }
    }
    private void LookAround()
    {
        if (player.GetComponent<CharacterMovement>().inBoat)
        {
            var cameraSpeed = 30;
            float xAxis = controls._3rdPersoncontroller.LookAround.ReadValue<Vector2>().x * Time.deltaTime;
            float yAxis = controls._3rdPersoncontroller.LookAround.ReadValue<Vector2>().y * Time.deltaTime;
            rotPoint.transform.Rotate(Vector3.up, xAxis * cameraSpeed);
            Debug.Log("Camera axis" + xAxis);

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

        //til at se på og ned men det virker ikke
        //mcCamera.transform.localEulerAngles = new Vector3(xRotationNow, 0, 0);

        //Vector2 rotation = controls._3rdPersoncontroller.LookAround.ReadValue<Vector2>();
        //rotPoint.transform.Rotate(0, 10 * rotation.x * Time.deltaTime, 0, Space.Self);
        //Debug.Log("look: vector" + rotation);
    }
}
