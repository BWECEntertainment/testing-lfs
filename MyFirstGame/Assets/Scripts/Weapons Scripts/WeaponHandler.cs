using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum WeaponAim
{
    NONE,
    SELF_AIM,
    AIM
}

public enum WeaponFireType
{
    SINGLE,
    MULTIPLE
}

public enum WeaponBulletType
{
    BULLET,
    ARROW,
    SPEAR,
    NONE


}






public class WeaponHandler : MonoBehaviour
{

    private Animator anim;

    public WeaponAim weapon_Aim;


    [SerializeField]
    private GameObject muzzleFlash;

    [SerializeField]
    private AudioSource shootSound, reload_Sound;

    public WeaponFireType fireType;

    public WeaponBulletType bulletType;

    public GameObject attack_Point;



    // Start is called before the first frame update
    void Awake()
    {

        anim = GetComponent<Animator>();

        
    }

    public void ShootAnimation()
    {
        anim.SetTrigger(AnimationTags.SHOOT_TRIGGER);
    }













}


