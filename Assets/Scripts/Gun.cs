using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour, ITakeble
{
    [SerializeField] private Transform _interactableObjects;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Bullet _bullet;

    private bool IsPicked = false;


    private void Update()
    {
        if (IsPicked == false)
            return;

        if (Input.GetKeyDown(KeyCode.Q))
            Shoot();
    }

    private void Shoot()
    {
        var bullet = Instantiate(_bullet, _shootPoint.transform.position, _shootPoint.rotation);
        bullet.Init();
    }

    public void Drop(Transform dropPosition)
    {
        IsPicked = false;
        gameObject.transform.SetParent(_interactableObjects);
        gameObject.transform.position = dropPosition.position;
    }

    public void PickUp(Transform holdPos)
    {
        IsPicked = true;
        gameObject.transform.SetParent(holdPos);
        gameObject.transform.position = holdPos.position;
        gameObject.transform.rotation = holdPos.rotation;
    }
}