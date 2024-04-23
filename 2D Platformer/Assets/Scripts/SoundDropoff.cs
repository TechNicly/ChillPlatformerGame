
using UnityEngine;

public class SoundDropoff : MonoBehaviour
{

    public GameObject player;
    private AudioSource audioSource;
    [SerializeField] private float soundDistance = 30f;
    [SerializeField] private float volumeValueChanger = 1f;



    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        VolumeChanger();
    }
    private void VolumeChanger(){
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if(distance < soundDistance && distance > 0){
            audioSource.volume = Mathf.Clamp(volumeValueChanger / distance, 0f, 1f);
        } else {
            audioSource.volume = 0;
        }
    }
}
