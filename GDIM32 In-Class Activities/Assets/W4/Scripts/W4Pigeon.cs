using UnityEngine;

public class W4Pigeon : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    [SerializeField] private Animator _animator;


    public delegate void PigeonCooAction();
    public event PigeonCooAction OnPigeonCoo;
    // REMOVE these references to other objects!
    // we're going to alert them via EVENT instead!!


    // HERE, add an event to tell other objects that the pigeon coo'd!


    // don't change the code in this method!
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Coo();
        }
    }

    private void Coo()
    {
        Debug.Log("squack!");

        // do pigeon stuff
        _audio.Play();
        _animator.SetTrigger("wiggle");

        OnPigeonCoo?.Invoke();
    }
}
