using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    //Controls
    private PlayerMovement _controls;

    //Movement
    private Vector3 _moveDirection;

    [SerializeField]
    private float _moveSpeed = 10f;

    private Vector3 _targetposition;

    private Vector3 _startPosition;

    private bool _isMoving;

    private int _tileSize = 10;

    //Collision
    [SerializeField]
    private float rayLength = 9f;

    [SerializeField]
    private float rayOffsetX = 5f;

    [SerializeField]
    private float rayOffsetY = 5f;

    [SerializeField]
    private float rayOffsetZ = 5f;

    [SerializeField]
    LayerMask layerToCollide;

    RaycastHit hit;

    Ray ray;

    //Player Detection

    [SerializeField]
    LayerMask playerLayer;

    private float viewDistance = 45f;

    //BPM Counter
    private float _beatCounter;

    [SerializeField]
    private float _timeWindow;

    //Shooting

    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    private float _bulletspeed;

    private float _bulletCooldown;

    private float _bulletTimer;

    private Quaternion _bulletRotation = Quaternion.Euler(90, 0, 0);

    private float _bulletSpan = 6f;

    private List<GameObject> bulletList = new List<GameObject> { };

    //Health Points

    [SerializeField]
    private float _maxHP;

    [SerializeField]
    private float _healAmount;

    [SerializeField]
    private float _dmgTaken;

    private float _healthPoints;

    [SerializeField]
    private Image _healthbar;

    private void DrawRays(Vector3 direction)
    {

        Debug.DrawRay(transform.position, Vector3.forward * 9, Color.red, 3f);
        Debug.DrawRay(transform.position, Vector3.back * 9, Color.red, 3f);
        Debug.DrawRay(transform.position, Vector3.left * 9, Color.red, 3f);
        Debug.DrawRay(transform.position, Vector3.right * 9, Color.red, 3f);
    }

    private bool CanMove(Vector3 direction)
    {

        if (Physics.Raycast(transform.position, direction, out hit, rayLength, layerToCollide))
        {

            Debug.Log($"Golpee a {hit.collider.gameObject} a {hit.distance}");
            return false;
        }

        return true;
    }

    private void CanSeePlayer()
    {
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, viewDistance, playerLayer))
        {
            Debug.Log($"Puedo a {hit.collider.gameObject} a {hit.distance}");

        }

    }

    private void Shoot()
    {

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (isOnBeat(_beatCounter, BeatsPerMinute._BeatsPerMinuteInstance._beatInterval, _timeWindow))
            {
                if (_bulletTimer >= _bulletCooldown)
                {
                    GameObject bullet = Instantiate(Bullet, transform.localPosition + new Vector3(0, 2, 6), _bulletRotation);
                    bulletList.Add(bullet);
                    Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
                    bulletRB.velocity = transform.forward * _bulletspeed;
                    Destroy(bullet, _bulletSpan);
                    _bulletTimer = 0;
                    //Destroy(bullet, bulletLifeSpan);
                }

            }

        }

    }

    private void Move()
    {

        if (_isMoving)
        {
            if (Vector3.Distance(_startPosition, transform.position) > 1f)
            {
                transform.position = _targetposition;
                _isMoving = false;
                return;
            }

            transform.position += (_targetposition - _startPosition) * _moveSpeed * Time.deltaTime;
            return;
        }

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            if (isOnBeat(_beatCounter, BeatsPerMinute._BeatsPerMinuteInstance._beatInterval, _timeWindow))
            {
                if (CanMove(Vector3.forward))
                {
                    _targetposition = transform.position + Vector3.forward * _tileSize;
                    _startPosition = transform.position;
                    _isMoving = true;
                }


                else
                {
                    _isMoving = false;
                    return;
                }

            }

        }

        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            if (isOnBeat(_beatCounter, BeatsPerMinute._BeatsPerMinuteInstance._beatInterval, _timeWindow))
            {
                if (CanMove(Vector3.back))
                {
                    _targetposition = transform.position + Vector3.back * _tileSize;
                    _startPosition = transform.position;
                    _isMoving = true;
                }


                else
                {
                    _isMoving = false;
                    return;
                }

            }


        }

        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            if (isOnBeat(_beatCounter, BeatsPerMinute._BeatsPerMinuteInstance._beatInterval, _timeWindow))
            {
                if (CanMove(Vector3.left))
                {
                    _targetposition = transform.position + Vector3.left * _tileSize;
                    _startPosition = transform.position;
                    _isMoving = true;
                }


                else
                {
                    _isMoving = false;
                    return;
                }

            }


        }

        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            if (isOnBeat(_beatCounter, BeatsPerMinute._BeatsPerMinuteInstance._beatInterval, _timeWindow))
            {
                if (CanMove(Vector3.right))
                {
                    _targetposition = transform.position + Vector3.right * _tileSize;
                    _startPosition = transform.position;
                    _isMoving = true;
                }


                else
                {
                    _isMoving = false;
                    return;
                }

            }


        }


    }

    private bool isOnBeat(float counter, float bpm, float window)
    {

        if (counter >= bpm + window)
        {
            counter = 0;
            return true;
        }
        else
        {
            Debug.Log($"counter reseta2");
            return false;
        }
    }



    private void Awake()
    {
        Debug.Log($"BPM es: {BeatsPerMinute._BeatsPerMinuteInstance._beatInterval}");
        _beatCounter += Time.deltaTime;

        _bulletCooldown = BeatsPerMinute._BeatsPerMinuteInstance._beatInterval * 3;

        _healthPoints = _maxHP;
    }

    void Start()
    {
        //Revamp to new input system later

        //_controls = new PlayerMovement();
        //_controls.Enable();

        //_controls.KeyBoard1.Movement.performed += ctx => {            
        //    _moveDirection = new Vector3(ctx.ReadValue<Vector2>().x, 0, ctx.ReadValue<Vector2>().y);          
        //};
        //_controls.KeyBoard1.Movement.canceled += ctx =>
        //{
        //    _moveDirection = new Vector3(0, 0, 0);
        //};

    }

    private void GetDamage()
    {
        _healthPoints -= _dmgTaken;
        if(_healthPoints < 0)
        {
            _healthPoints = 0;
        }
        var hpPercentage = _healthPoints / _maxHP;
        _healthbar.fillAmount = hpPercentage;
    }

    private void HealPlayer()
    {
        _healthPoints += _healAmount;
        if(_healthPoints < _maxHP)
        {
            _healthPoints = _maxHP;
        }
        var hpPercentage = _healthPoints / _maxHP;
        _healthbar.fillAmount = hpPercentage;
    }

    void Update()
    {
        DrawRays(_moveDirection);
        Move();
        CanSeePlayer();
        Shoot();
        if (Input.GetKeyDown(KeyCode.J))
        {
            GetDamage();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            HealPlayer();
        }


        _beatCounter += Time.deltaTime;
        _bulletTimer += Time.deltaTime;

    }
}
