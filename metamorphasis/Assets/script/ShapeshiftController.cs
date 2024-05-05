using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class ShapeshiftController : MonoBehaviour
{
    #region public components
    public Sprite originalSprite;
    public AnimatorController originalController;
    public Sprite  transformedSprite1;
    public float transformationDuration = 5.0f;
    public float cooldownDuration = 10.0f;
    public bool isTransformed = false;
    public bool isOnCooldown = false;
    public GameObject pSystem;
    public AnimatorController controller1;
 
    #endregion

    #region private components
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    #endregion

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transformation();
            cooldownDuration = 10.0f;
            transformationDuration = 5.0f;
        }

        if (isTransformed)
        {
            transformationDuration -= Time.deltaTime;
            Debug.Log(transformationDuration);
            if (transformationDuration <= 0)
            {
                RevertTransformation();
                isOnCooldown = true;
            }

        }
        if (isOnCooldown)
        {
            cooldownDuration -= Time.deltaTime;
            Debug.Log(cooldownDuration);
            if (cooldownDuration <= 0)
            {
                isOnCooldown = false;
                isTransformed = false;
            }
        }
    }
    public void Transformation()
    {
        GameObject effect = (GameObject)(Instantiate(pSystem, transform.position, transform.rotation));
        if (!isTransformed)
        {
            spriteRenderer.sprite = transformedSprite1;
            animator.runtimeAnimatorController = controller1;
            isTransformed = true;
        }
        Destroy(effect, 0.2f);
    }
    public void RevertTransformation()
    {
        GameObject effect = (GameObject)(Instantiate(pSystem, transform.position, transform.rotation));
        spriteRenderer.sprite = originalSprite;
        animator.runtimeAnimatorController = originalController;
        isTransformed = false;
        if (!isOnCooldown)
        {
            isOnCooldown = true;
        }
        Destroy(effect, 0.2f);
    }
}
