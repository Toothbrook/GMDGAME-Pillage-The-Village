using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent _navMeshAgent;
    public Transform _player;
    public LayerMask groundMask;
    public LayerMask playerMask;
    private Animator animator;
    private HealthBarScript _health;
    public Transform _mainCharacter;
    public float _damageTaken = 25;
    public float Health = 100;
    public delegate void EnemyDestroyed();
    public static event EnemyDestroyed OnEnemyDestroyed;
    public ScoreScript score;


    //Patrol
    public Vector3 _patrolPoint;
    bool _patrolPointSet;
    public float _patrolPointRange;

    //Attack
    public float _delayBetweenAttack;
    bool _alreadyAttacked = false;

    //State
    public float _rangeOfSight;
    public float _rangeOfAttack;
    public bool _playerInSightRange;
    public bool _playerInAttackRange;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("EnemyAI").transform;
        _navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        _mainCharacter = GameObject.Find("MC").transform;
        _health = GetComponentInChildren<HealthBarScript>();
        _health.SetMaxHealth(Health);
        score = GameObject.Find("Score").GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check to see if anybody is in range of sight or attack
        _playerInSightRange = Physics.CheckSphere(transform.position, _rangeOfSight, playerMask);
        _playerInAttackRange = Physics.CheckSphere(transform.position, _rangeOfAttack, playerMask);

        if (_playerInSightRange && _playerInAttackRange)
        {
            AttackPlayer();
        }
        if (_playerInSightRange && !_playerInAttackRange)
        {
            Chase();
        }
        if (!_playerInAttackRange && !_playerInSightRange)
        {
            Patrolling();
        }

    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Weapon"))
        {
           
                DamageTaken(_damageTaken);
                Debug.Log("Enemy hit, hp left: " + HpLeft());
            
            
        }



    }

    private void Patrolling()
    {
        if (!_patrolPointSet)
        {
            NewPatrolPoint();
        }

        if (_patrolPointSet)
        {
            _navMeshAgent.SetDestination(_patrolPoint);
        }

        Vector3 distanceToPatrolPoint = _player.position - _patrolPoint;
        if (distanceToPatrolPoint.magnitude < 1f)
        {
            _patrolPointSet = false;
        }
    }

    private void NewPatrolPoint()
    {
        //Search for a New Patrol Point
        float x = Random.Range(-_patrolPointRange, _patrolPointRange);
        float z = Random.Range(-_patrolPointRange, _patrolPointRange);
        _patrolPoint = new Vector3(_player.position.x + x, _player.position.y, _player.position.z + z);

        if (Physics.Raycast(_patrolPoint, -transform.up, 2f, groundMask))
        {
            _patrolPointSet = true;
        }

    }

    private void Chase()
    {
        _navMeshAgent.SetDestination(_mainCharacter.position);
    }

    private void AttackPlayer()
    {
        _navMeshAgent.SetDestination(transform.position);

        transform.LookAt(_mainCharacter);

        if (!_alreadyAttacked)
        {
            animator.SetTrigger("Attack");

            _alreadyAttacked = true;
            Invoke(nameof(ResetAttack), _delayBetweenAttack);
        }
    }

    private void ResetAttack()
    {
        _alreadyAttacked = false;
    }

    private void DamageTaken(float dmg)
    {        
        Health -= dmg;
        _health.SetHealth(Health);
        Debug.Log("Health: " + Health);
        if (Health <= 0)
        {
            animator.SetBool("Dead", true);
            Invoke(nameof(DestroyEnemy), 3f);
        }
    }

    private void DestroyEnemy()
    {
        Destroy(gameObject);

        score.addScore();

        if (OnEnemyDestroyed != null)
        {
            OnEnemyDestroyed();
        }
    }

    private float HpLeft()
    {
        return Health;
    }

}
