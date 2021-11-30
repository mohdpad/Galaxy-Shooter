using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;

    private Player _player;
    private Animator _anim;                                                                                                      // handle to animator component

    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        _audioSource = GetComponent<AudioSource>();
        if(_player == null)
        {
            Debug.LogError("Player is NULL");
        }

        _anim = GetComponent<Animator>();                                                            //assign the component to anim

        if(_anim==null)
        {
            Debug.LogError("Animator is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);  

        if(transform.position.y < -6f)                                                                                            //random enemy spawing
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 7, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();                                               //calls damage method from player script

            if(player != null)                                                                                      //checks if that method exists
            {
                player.Damage();
            }

            _anim.SetTrigger("OnEnemyDeath");                                                                   //trigger anim 
            _speed = 0;
            _audioSource.Play();
            Destroy(this.gameObject,2.30f);
          
        }

        if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            if(_player != null)
            {
                _player.AddScore(10);                                                                            //adds 10 to score when enemy is hit
            }

            _anim.SetTrigger("OnEnemyDeath");                                       //trigger anim
            _speed = 0;
            _audioSource.Play();             //calls audio method
            Destroy(this.gameObject,2.30f);
             
        }
    }
}
