using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Min
{
    public class WeapenSystem : MonoBehaviour
    {
        [SerializeField, Header("子彈生成點")]
        private Transform point;
        [SerializeField, Header("子彈預制物")]
        private GameObject PreFabBullet;
        [SerializeField, Header("子彈速度"),Range(0,2000)]
        private int Bulletspeed = 1000;
        [SerializeField, Header("開槍特效")]
        private ParticleSystem fire;
        [SerializeField, Header("開槍音效")]
        private AudioClip soundFire;

        private AudioSource aud;
        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        public void Fire()
        {
            //生成子彈在槍口並設定0度角
            GameObject temp = Instantiate(PreFabBullet, point.position, Quaternion.identity);
            //獲得子彈鋼體並添加一個槍口前方*速度的推力
            temp.GetComponent<Rigidbody>().AddForce(point.forward*Bulletspeed) ;   
            fire.Play();
            aud.PlayOneShot(soundFire);
        }
    }
}


