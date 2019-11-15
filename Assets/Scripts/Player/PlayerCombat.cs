using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public GameObject instanceWeapon;
	public GameObject hitbox;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ///neste if/else é onde o jogador liga e desliga a arma, deve ser por aqui que deves meter a animação
        if(Input.GetMouseButtonDown(0))
        {
            instanceWeapon.SetActive(true);
			hitbox.SetActive(true);
        } else {
            instanceWeapon.SetActive(false);
			hitbox.SetActive(false);
        }
    }
}
