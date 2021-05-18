using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulette : MonoBehaviour
{
    [Header("rollingSpeed")]
    public float rotSpeed = 5f;

    [Header("rollingSound")]
    public AudioSource roulettesound;

    [Header("endImage")]
    public GameObject endImage;    
    public GameObject reStart;
    
    [Header("particle")]
    public ParticleSystem endParticle;


   
    private float speed;
    private bool isStart;
    private bool isFinish;
    // Start is called before the first frame update
    void Start()
    {
        isStart = false;
        isFinish = false;
        endImage.SetActive(false);
        reStart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            speed= rotSpeed;
            roulettesound.Play();
            isStart = true;
        }
        transform.Rotate(0,0,this.speed);

        //this.speed *= 0.999f;
        this.speed *= 0.96f;

        
        if(this.speed <= 0.01f && isStart && !isFinish)
        {
            isFinish = true;
            Debug.Log("the rotate is stop");
            speed = 0f;
            endImage.SetActive(true);
          
            
            //endParticle.Stop();
        }
        if(isFinish)
          StartCoroutine(particle());
    }

    IEnumerator particle()
    {
        endParticle.Play();

        yield return new WaitForSeconds(2.0f);
        endParticle.Stop();
        //endImage.SetActive(false);

        isFinish =false;
        isStart = false;
        reStart.SetActive(true);
        
    }
}
