using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverKnight : MonoBehaviour
{

    private Animator walk;
    private float velocity = 6.5f;
    // Start is called before the first frame update

    private void Awake()
    {
        walk = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorClipInfo[] clipInfo;
        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        clipInfo = walk.GetCurrentAnimatorClipInfo(0);
        if (tecladoHorizontal == 1)
        {
            if(clipInfo[0].clip.name.Equals("WalkLeft")) {
                walk.Rebind();
            } 
            
            walk.SetTrigger("WalkRight");
            transform.position = new Vector2(transform.position.x + (velocity * Time.deltaTime), transform.position.y);

        }else if (tecladoHorizontal == -1)
        {
            if (clipInfo[0].clip.name.Equals("WalkRight")){
                walk.Rebind();
            }
            walk.SetTrigger("WalkLeft");
            transform.position = new Vector2((transform.position.x - (velocity * Time.deltaTime)), transform.position.y);
        }
    }
}
