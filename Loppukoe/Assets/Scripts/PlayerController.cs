using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    AnimationController animationController;
    SoundController soundController;

    Vector2 direction = Vector2.down;

	void Start () {

	}
	

	void Update () {

		if (Input.GetKeyDown(KeyCode.W)){
            //koodi liikkumiselle ylöspäin
            //kutsu animaattorista oikea animaatio.
            //direction = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.S)){
            //koodi liikkumiselle alaspäin
            //kutsu animaattorista oikea animaatio.
            //direction =
        }
        if (Input.GetKeyDown(KeyCode.A)){
            //koodi liikkumiselle vasemmalle
            //kutsu animaattorista oikea animaatio.
            //direction =
        }
        if (Input.GetKeyDown(KeyCode.D)){
            //koodi liikkumiselle oikealle
            //kutsu animaattorista oikea animaatio.
            //direction =
        }
    }

    void FixedUpdate()
    {
        RaycastForward(direction);
    }

    void RaycastForward(Vector2 dir)
    {
        //Raycasthit2D hit

        //Ensimmäinen ensimerkki Unityn sivuilta näyttää oikean suunnan ratkaisulle.
        //https://docs.unity3d.com/ScriptReference/Physics2D.Raycast.html
        //Voit myös halutessasi tehdä aivan muunlaisen ratkaisun.
        //Saat raycastin näkyviin Scenessä komennolla Debug.DrawRay(transform.position, dir);

        //vihje (ei välttämättä toimi tuollaisenaan)
        //if (hit.collider.comparetag("secret"))
        //audiosource = hit.collider.getcomponent<audiosource>().play()......

    }
}
