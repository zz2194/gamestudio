using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TriggerScripts : MonoBehaviour
{
    public Animation anim;
    public AnimationClip[] anims;
    public int platformLabel;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.name.Contains("Player"))
        {
            if(platformLabel == 1)
            {
            anim.clip = anims[0];
            if(!anim.IsPlaying("moveup"))
            anim.Play();
            }
            if(platformLabel == 2)
            {
            anim.clip = anims[2];
            if(!anim.IsPlaying("moveupSniper"))
            anim.Play();
            }
            if(platformLabel == 3)
            {
            anim.clip = anims[0];
            if(!anim.IsPlaying("movedownDoor"))
            anim.Play();
            }
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name.Contains("Player"))
        {
            if(platformLabel == 1)
            {
            anim.clip = anims[1];
            if(!anim.IsPlaying("movedown"))
            anim.Play();
            }
            if(platformLabel == 2)
            {
            anim.clip = anims[3];
            if(!anim.IsPlaying("movedownSniper"))
            anim.Play();
            }
            if(platformLabel == 3)
            {
            anim.clip = anims[1];
            if(!anim.IsPlaying("moveupDoor"))
            anim.Play();
            }
        }
    }
}
