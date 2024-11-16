using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Min
{
    public class WeapenSystem : MonoBehaviour
    {
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform point;
        [SerializeField, Header("�l�u�w�")]
        private GameObject PreFabBullet;
        [SerializeField, Header("�l�u�t��"),Range(0,2000)]
        private int Bulletspeed = 1000;
        [SerializeField, Header("�}�j�S��")]
        private ParticleSystem fire;
        [SerializeField, Header("�}�j����")]
        private AudioClip soundFire;

        private AudioSource aud;
        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        public void Fire()
        {
            //�ͦ��l�u�b�j�f�ó]�w0�ר�
            GameObject temp = Instantiate(PreFabBullet, point.position, Quaternion.identity);
            //��o�l�u����òK�[�@�Ӻj�f�e��*�t�ת����O
            temp.GetComponent<Rigidbody>().AddForce(point.forward*Bulletspeed) ;   
            fire.Play();
            aud.PlayOneShot(soundFire);
        }
    }
}


