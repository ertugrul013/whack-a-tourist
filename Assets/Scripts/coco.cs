using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coco : MonoBehaviour
{

    public float ballDistance;
    public float ballForce;

    AudioSource audiosource;
    public AudioClip[] hitSounds;
    AudioClip audioclip;


    ParticleSystem party;
   
    private void Awake()
    {   
        throwCoco();
        audiosource = GetComponent<AudioSource>();
 
        party = GetComponent<ParticleSystem>();
        party.Stop();
    }
    
    /// <summary>
    /// random uitleg dingen
    /// </summary>
    /// 

    public void throwCoco()
    {     
            gameObject.GetComponent<Rigidbody>().useGravity = true;            
            gameObject.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * ballForce);       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="ding")
        {

            party.Play();

            int index = Random.Range(0, hitSounds.Length);
            audioclip = hitSounds[index];
            audiosource.clip = audioclip;
            audiosource.Play();
  
        }

        if (collision.gameObject.tag == "grond")
        {
            Destroy(gameObject);
            party.Stop();
        }
    }

}
